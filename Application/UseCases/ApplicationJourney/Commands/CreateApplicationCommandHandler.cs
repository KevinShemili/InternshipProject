using Application.UseCases.ApplicationJourney.Results;
using FluentValidation;
using MediatR;

namespace Application.UseCases.ApplicationJourney.Commands {

    public class CreateApplicationCommand : IRequest<ApplicationCommandResult> {
        public int RequestedAmount { get; set; }
        public int RequestedTenor { get; set; }
        public string FinancePurposeDefinition { get; set; } = null!;

    }

    public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, ApplicationCommandResult> {
        public Task<ApplicationCommandResult> Handle(CreateApplicationCommand request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }

    public class CreateApplicationCommandValidator : AbstractValidator<CreateApplicationCommand> {
        public CreateApplicationCommandValidator() {

        }
    }
}
