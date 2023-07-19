using MediatR;

namespace Application.UseCases.ResendEmailVerification.Commands {
    public class ResendEmailVerificationCommand : IRequest {
        public string Email { get; set; } = null!;
    }
}
