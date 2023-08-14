using Application.Persistance;
using Application.UseCases.LenderCases.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LenderCases.Queries {

    public class GetEligibleLendersQuery : IRequest<List<LenderQueryResult>> {
        public Guid Id { get; set; }
    }

    public class GetEligibleLendersQueryHandler : IRequestHandler<GetEligibleLendersQuery, List<LenderQueryResult>> {

        private readonly ILenderRepository _lenderRepository;
        private readonly IApplicationRepository _applicationRepository;
        private readonly IStringLocalizer<LocalizationResources> _localization;
        private readonly IMapper _mapper;


        public GetEligibleLendersQueryHandler(IApplicationRepository applicationRepository,
                                              ILenderRepository lenderRepository,
                                              IStringLocalizer<LocalizationResources> localization,
                                              IMapper mapper) {
            _applicationRepository = applicationRepository;
            _lenderRepository = lenderRepository;
            _localization = localization;
            _mapper = mapper;
        }

        public async Task<List<LenderQueryResult>> Handle(GetEligibleLendersQuery request, CancellationToken cancellationToken) {

            if (await _applicationRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("ApplicationDoesntExist").Value);

            var application = await _applicationRepository.GetByIdAsync(request.Id);
            var companyType = await _applicationRepository.GetCompanyTypeAsync(request.Id);
            var lenders = await _lenderRepository.GetAllAsync();

            var eligibles = new List<Lender>();
            foreach (var lender in lenders) {
                if (IsTenorAccepted(lender, application.RequestedTenor) is false)
                    continue;

                if (IsRequestAmountAccepted(lender, application.RequestedAmount) is false)
                    continue;

                if (IsCompanyTypeAccepted(lender, companyType) is false)
                    continue;

                eligibles.Add(lender);
            }

            if (eligibles.Any() is false)
                throw new NoSuchEntityExistsException(_localization.GetString("NoEligibleLendersFound").Value);

            return _mapper.Map<List<LenderQueryResult>>(eligibles);
        }

        private static bool IsTenorAccepted(Lender lender, int tenor) {
            if (lender.MinTenor < tenor && lender.MaxTenor > tenor)
                return true;
            return false;
        }

        private static bool IsRequestAmountAccepted(Lender lender, int amount) {
            return lender.RequestedAmount < amount;
        }

        private static bool IsCompanyTypeAccepted(Lender lender, string type) {
            return lender.BorrowerCompanyType == type;
        }
    }

    public class GetEligibleLendersQueryValidator : AbstractValidator<GetEligibleLendersQuery> {
        public GetEligibleLendersQueryValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
