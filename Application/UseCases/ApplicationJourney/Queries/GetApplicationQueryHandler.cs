using Application.Persistance;
using Application.UseCases.ApplicationJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ApplicationJourney.Queries {

    public class GetApplicationQuery : IRequest<ApplicationQueryResult> {
        public Guid ApplicationId { get; set; }
    }

    public class GetApplicationQueryHandler : IRequestHandler<GetApplicationQuery, ApplicationQueryResult> {

        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public GetApplicationQueryHandler(IMapper mapper, IApplicationRepository applicationRepository, IStringLocalizer<LocalizationResources> localization) {
            _mapper = mapper;
            _applicationRepository = applicationRepository;
            _localization = localization;
        }

        public async Task<ApplicationQueryResult> Handle(GetApplicationQuery request, CancellationToken cancellationToken) {

            if (await _applicationRepository.ContainsAsync(request.ApplicationId) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("ApplicationDoesntExist").Value);

            var application = await _applicationRepository.GetByIdAsync(request.ApplicationId);

            return _mapper.Map<ApplicationQueryResult>(application);
        }
    }

    public class GetApplicationQueryValidator : AbstractValidator<GetApplicationQuery> {
        public GetApplicationQueryValidator() {
            RuleFor(x => x.ApplicationId)
                .NotEmpty().WithMessage("EmptyApplicationId");
        }
    }
}
