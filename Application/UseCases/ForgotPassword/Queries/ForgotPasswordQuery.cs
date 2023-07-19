using MediatR;

namespace Application.UseCases.ForgotPassword.Queries {
    public class ForgotPasswordQuery : IRequest {
        public string Email { get; set; } = null!;
    }
}
