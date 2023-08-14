using Application.Persistance;
using Application.UseCases.ApplicationJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ApplicationJourney.Queries {

    public class GetApplicationByBorrowerQuery : IRequest<ApplicationQueryResult> {
        public Guid BorrowerId { get; set; }
        public Guid ApplicationId { get; set; }
    }

    public class GetApplicationByBorrowerQueryHandler : IRequestHandler<GetApplicationByBorrowerQuery, ApplicationQueryResult> {

        private readonly IApplicationRepository _applicationRepository;
        private readonly IStringLocalizer<LocalizationResources> _localization;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;

        public GetApplicationByBorrowerQueryHandler(IMapper mapper,
                                                    IStringLocalizer<LocalizationResources> localization,
                                                    IApplicationRepository applicationRepository,
                                                    IBorrowerRepository borrowerRepository) {
            _mapper = mapper;
            _localization = localization;
            _applicationRepository = applicationRepository;
            _borrowerRepository = borrowerRepository;
        }

        public async Task<ApplicationQueryResult> Handle(GetApplicationByBorrowerQuery request, CancellationToken cancellationToken) {
            if (await _borrowerRepository.ContainsAsync(request.BorrowerId) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("BorrowerDoesntExist").Value);

            if (await _applicationRepository.ContainsAsync(request.ApplicationId) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("ApplicationDoesntExist").Value);

            var application = await _applicationRepository.GetApplicationByBorrower(request.BorrowerId, request.ApplicationId);

            return _mapper.Map<ApplicationQueryResult>(application);
        }
    }

    public class GetApplicationByBorrowerQueryValidator : AbstractValidator<GetApplicationByBorrowerQuery> {
        public GetApplicationByBorrowerQueryValidator() {
            RuleFor(x => x.BorrowerId)
                .NotEmpty().WithMessage("EmptyId");
            RuleFor(x => x.ApplicationId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
