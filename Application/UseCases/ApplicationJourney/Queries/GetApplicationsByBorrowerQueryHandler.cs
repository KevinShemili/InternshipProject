using Application.Persistance;
using Application.UseCases.ApplicationJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ApplicationJourney.Queries {

    public class GetApplicationsByBorrowerQuery : IRequest<List<ApplicationQueryResult>> {
        public Guid Id { get; set; }
    }

    public class GetApplicationsByBorrowerQueryHandler : IRequestHandler<GetApplicationsByBorrowerQuery, List<ApplicationQueryResult>> {

        private readonly IApplicationRepository _applicationRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IStringLocalizer<LocalizationResources> _localization;
        private readonly IMapper _mapper;

        public GetApplicationsByBorrowerQueryHandler(IApplicationRepository applicationRepository, IBorrowerRepository borrowerRepository, IStringLocalizer<LocalizationResources> localization, IMapper mapper) {
            _applicationRepository = applicationRepository;
            _borrowerRepository = borrowerRepository;
            _localization = localization;
            _mapper = mapper;
        }

        public async Task<List<ApplicationQueryResult>> Handle(GetApplicationsByBorrowerQuery request, CancellationToken cancellationToken) {
            if (await _borrowerRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("BorrowerDoesntExist").Value);

            var applications = await _applicationRepository.GetApplications(request.Id);

            return _mapper.Map<List<ApplicationQueryResult>>(applications);
        }
    }

    public class GetApplicationsByBorrowerQueryValidator : AbstractValidator<GetApplicationsByBorrowerQuery> {
        public GetApplicationsByBorrowerQueryValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
