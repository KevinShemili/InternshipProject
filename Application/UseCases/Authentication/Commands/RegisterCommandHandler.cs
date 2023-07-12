using Application.Persistance;
using Application.UseCases.Authentication.Common;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Authentication.Commands {
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResult> {

        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken) {
            var user = new User {
                Id = Guid.NewGuid(),
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PasswordHash = request.Password,
                PasswordSalt = request.Password,
                Username = request.Username,
                Prefix = request.Prefix,
                PhoneNumber = request.Phone,
            };

            _userRepository.Create(user);

            var returnResult = new RegisterResult {
                Id = user.Id,
                Username = user.Username
            };

            return returnResult;
        }
    }
}
