using Application.Persistance;
using Application.Persistance.Common;
using Application.UseCases.ApplicationJourney.Results;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ApplicationJourney.Commands {

    public class CreateApplicationCommand : IRequest<ApplicationCommandResult> {
        public int RequestedAmount { get; set; }
        public int RequestedTenor { get; set; }
        public string FinancePurposeDefinition { get; set; } = null!;
    }

    public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, ApplicationCommandResult> {

        private readonly IApplicationRepository _applicationRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public CreateApplicationCommandHandler(IStringLocalizer<LocalizationResources> localizer,
            IApplicationRepository applicationRepository,
            IUnitOfWork unitOfWork) {
            _localizer = localizer;
            _applicationRepository = applicationRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<ApplicationCommandResult> Handle(CreateApplicationCommand request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }

    public class CreateApplicationCommandValidator : AbstractValidator<CreateApplicationCommand> {
        public CreateApplicationCommandValidator() {

        }
    }
}
