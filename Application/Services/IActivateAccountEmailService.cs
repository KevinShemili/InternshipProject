using Application.UseCases.Authentication.Commands;

namespace Application.Services {
    public interface IActivateAccountEmailService {
        public Task<bool> SendActivationEmail(RegisterCommand request, CancellationToken cancellationToken);
        public Task<bool> ResendActivationEmail(string email, CancellationToken cancellationToken);
    }
}
