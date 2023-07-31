using Application.Interfaces.Authentication;
using Application.Persistance;
using Application.UseCases.BorrowerJourney.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;
using System.Text.Json;

namespace Application.UseCases.BorrowerJourney.Commands {

    public class CreateBorrowerCommmand : IRequest<BorrowerResult> {
        public string AccessToken { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CompanyType { get; set; } = null!;
        public string VATNumber { get; set; } = null!;
        public int FiscalCode { get; set; }
    }

    public class CreateBorrowerCommandHandler : IRequestHandler<CreateBorrowerCommmand, BorrowerResult> {

        private readonly IUserRepository _userRepository;
        private readonly IStringLocalizer<LocalizationResources> _localization;
        private readonly IMapper _mapper;
        private readonly ICompanyTypeRepository _companyTypeRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IJwtToken _jwtToken;

        public CreateBorrowerCommandHandler(IStringLocalizer<LocalizationResources> localization, IUserRepository userRepository, IMapper mapper, ICompanyTypeRepository companyTypeRepository, IBorrowerRepository borrowerRepository, IJwtToken jwtToken) {
            _localization = localization;
            _userRepository = userRepository;
            _mapper = mapper;
            _companyTypeRepository = companyTypeRepository;
            _borrowerRepository = borrowerRepository;
            _jwtToken = jwtToken;
        }

        public async Task<BorrowerResult> Handle(CreateBorrowerCommmand request, CancellationToken cancellationToken) {

            if (_jwtToken.IsExpired(request.AccessToken) is true)
                throw new ForbiddenException(_localization.GetString("LoginExpired"));

            var userId = _jwtToken.GetUserId(request.AccessToken);

            if (await _userRepository.ContainsIdAsync(userId) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("UnathorizedAccess").Value);

            if (await _companyTypeRepository.ContainsAsync(request.CompanyType) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("CompanyTypeDoesntExist").Value);

            var borrower = _mapper.Map<Borrower>(request);
            var borrowerId = Guid.NewGuid();
            borrower.Id = borrowerId;

            var companyType = await _companyTypeRepository.GetByNameAsync(request.CompanyType);

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://finnhub.io/api/v1/stock/");

            var response = await client.GetAsync(client.BaseAddress + $"profile2?symbol={request.CompanyName}&token=cj3rfthr01qlttl4igc0cj3rfthr01qlttl4igcg");

            if (response.IsSuccessStatusCode is false)
                throw new HttpRequestException(response.ReasonPhrase);

            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<CompanyProfile>(stringResponse,
            new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            borrower.CompanyProfile = result;
            borrower.CompanyType = companyType;

            await _userRepository.AddBorrowerAsync(userId, borrower);

            throw new Exception();
        }
    }

    public class CreateBorrowerCommandValidator : AbstractValidator<CreateBorrowerCommmand> {
        public CreateBorrowerCommandValidator() {
            RuleFor(x => x.CompanyName)
                .NotEmpty().WithMessage("EmptyCompanyName");

            RuleFor(x => x.CompanyType)
                .NotEmpty().WithMessage("EmptyCompanyType");

            RuleFor(x => x.VATNumber)
                .NotEmpty().WithMessage("EmptyVATNumber")
                .Length(11).WithMessage("VATNumberLengthRestriction");

            RuleFor(x => x.FiscalCode)
            .Must((command, fiscalCode) => ValidateFiscalCodeLength(command.CompanyType, fiscalCode))
            .WithMessage("FiscalCodeLengthRestriction");
        }

        private bool ValidateFiscalCodeLength(string companyType, int fiscalCode) {
            if (companyType == "Sole Proprietorship") {
                string fiscalCodeStr = fiscalCode.ToString();
                return fiscalCodeStr.Length == 16;
            }
            else if (companyType == "Other") {
                string fiscalCodeStr = fiscalCode.ToString();
                return fiscalCodeStr.Length == 11;
            }
            return true; // For other company types no restrictions
        }
    }
}
