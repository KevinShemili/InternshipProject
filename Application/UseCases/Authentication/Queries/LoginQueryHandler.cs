using Application.Interfaces.Authentication;
using Application.Persistance;
using Application.Services;
using Application.UseCases.Authentication.Common;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.Authentication.Queries
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginResult> {

        private readonly IUserRepository _userRepository;
        private readonly IJwtToken _jwtToken;
        private readonly IHasherService _hasherService;

        public LoginQueryHandler(IUserRepository userRepository, IJwtToken jwtToken, IHasherService hasherService) {
            _userRepository = userRepository;
            _jwtToken = jwtToken;
            _hasherService = hasherService;
        }

        public async Task<LoginResult> Handle(LoginQuery request, CancellationToken cancellationToken) {
            var user = await _userRepository.GetByUsernameAsync(request.Username);

            if (user == null)
                throw new NoSuchUserExistsException("Username doesn't exist");

            var flag = _hasherService.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);

            if (flag is false)
                throw new InvalidPasswordException("Incorrect Password");

            var roles = await _userRepository.GetRolesAsync(user.Id);

            var token = _jwtToken.GenerateToken(user.Id, user.Username, roles);

            var loginResult = new LoginResult {
                Id = user.Id,
                Token = token
            };

            return loginResult;
        }
    }
}
