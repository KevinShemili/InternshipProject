using Application.UseCases.Authentication.Results;
using MediatR;

namespace Application.UseCases.Authentication.Queries {
    public class LoginQuery : IRequest<LoginResult> {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
