using MediatR;

namespace Application.UseCases.ForgotUsername.Queries {
    public class ForgotUsernameQuery : IRequest {
        public string Email { get; set; } = null!;
    }
}
