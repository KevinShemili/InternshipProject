using Application.Persistance;
using Application.Services;
using MediatR;

namespace Application.UseCases.ResendEmailVerification {
    public class ResendEmailVerificationCommandHandler : IRequestHandler<ResendEmailVerificationCommand> {

        private readonly IActivateAccountEmailService _activateAccountEmailService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;

        public ResendEmailVerificationCommandHandler(IActivateAccountEmailService activateAccountEmailService, IUserVerificationAndResetRepository userVerificationAndResetRepository) {
            _activateAccountEmailService = activateAccountEmailService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
        }

        public async Task Handle(ResendEmailVerificationCommand request, CancellationToken cancellationToken) {

            await _activateAccountEmailService.ResendActivationEmail(request.Email, cancellationToken);
        }
    }
}
