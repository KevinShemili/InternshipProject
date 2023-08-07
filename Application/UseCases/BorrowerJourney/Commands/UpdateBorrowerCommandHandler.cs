using Application.Persistance;
using Application.Persistance.Common;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;
using System.Text.Json;

namespace Application.UseCases.BorrowerJourney.Commands {

    public class UpdateBorrowerCommand : IRequest<bool> {
        public Guid Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string CompanyType { get; set; } = null!;
        public string VATNumber { get; set; } = null!;
        public string FiscalCode { get; set; } = null!;
    }

    public class UpdateBorrowerCommandHandler : IRequestHandler<UpdateBorrowerCommand, bool> {

        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly ICompanyTypeRepository _companyTypeRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICompanyProfileRepository _companyProfileRepository;

        public UpdateBorrowerCommandHandler(IStringLocalizer<LocalizationResources> localizer,
            ICompanyTypeRepository companyTypeRepository, IBorrowerRepository borrowerRepository, IMapper mapper,
            IUnitOfWork unitOfWork, ICompanyProfileRepository companyProfileRepository) {
            _localizer = localizer;
            _companyTypeRepository = companyTypeRepository;
            _borrowerRepository = borrowerRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyProfileRepository = companyProfileRepository;
        }

        public async Task<bool> Handle(UpdateBorrowerCommand request, CancellationToken cancellationToken) {

            if (await _borrowerRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException("BorrowerDoesntExist");

            var borrower = await _borrowerRepository.GetByIdAsync(request.Id);

            if (await _companyTypeRepository.ContainsAsync(request.CompanyType) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("CompanyTypeDoesntExist").Value);

            if (await _borrowerRepository.IsFiscalCodeUniqueAsync(borrower.UserId, request.FiscalCode) is false)
                throw new DuplicateException(_localizer.GetString("DuplicateFiscalCode").Value);

            var updateBorrower = new Borrower {
                CompanyName = request.CompanyName,
                VATNumber = request.VATNumber,
                FiscalCode = request.FiscalCode,
                CompanyType = await _companyTypeRepository.GetByNameAsync(request.CompanyType),
            };

            await _companyProfileRepository.UpdateAsync(borrower.CompanyProfile.Id, await GetCompanyProfile(request.CompanyName));
            await _borrowerRepository.UpdateAsync(request.Id, updateBorrower);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        private static async Task<CompanyProfile> GetCompanyProfile(string companyName) {
            var client = new HttpClient {
                BaseAddress = new Uri("https://finnhub.io/api/v1/stock/")
            };

            var response = await client.GetAsync(client.BaseAddress
                + $"profile2?symbol={companyName}&token=cj3rfthr01qlttl4igc0cj3rfthr01qlttl4igcg");

            if (response.IsSuccessStatusCode is false)
                throw new HttpRequestException(response.ReasonPhrase);

            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<CompanyProfile>(stringResponse,
                                                              new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            return result is null ? throw new Exception() : result;
        }
    }

    public class UpdateBorrowerCommandValidator : AbstractValidator<UpdateBorrowerCommand> {
        public UpdateBorrowerCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");

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

        private static bool ValidateFiscalCodeLength(string companyType, string fiscalCode) {
            if (companyType == "Sole Proprietorship")
                return fiscalCode.Length == 16;
            else if (companyType == "Other")
                return fiscalCode.Length == 11;

            return true; // For other company types no restrictions
        }
    }
}
