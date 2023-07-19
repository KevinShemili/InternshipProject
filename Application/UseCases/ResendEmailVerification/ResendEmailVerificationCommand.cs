using MediatR;

namespace Application.UseCases.ResendEmailVerification {
    public class ResendEmailVerificationCommand : IRequest {
        public string Email { get; set; } = null!;
    }
}
