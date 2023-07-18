using MediatR;

namespace Application.UseCases.ActivateAccount.Commands {
    public class ActivateAccountCommand : IRequest {
        public string Token { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
