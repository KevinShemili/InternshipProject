using Application.UseCases.Authentication.Results;
using MediatR;

namespace Application.UseCases.Authentication.Commands {
    public class RegisterCommand : IRequest<RegisterResult> {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Prefix { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
