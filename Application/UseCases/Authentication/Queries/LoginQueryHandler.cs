using Application.Interfaces.Authentication;
using Application.Interfaces.Common;
using Application.Persistance;
using Application.UseCases.Authentication.Common;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.Authentication.Queries {
    public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginResult> {

        private readonly IUserRepository _userRepository;
        private readonly IJwtToken _jwtToken;

        public LoginQueryHandler(IUserRepository userRepository, IJwtToken jwtToken) {
            _userRepository = userRepository;
            _jwtToken = jwtToken;
        }


        public async Task<LoginResult> Handle(LoginQuery request, CancellationToken cancellationToken) {
            var user = _userRepository.GetUserByUsername(request.Username);

            if (user == null) {
                throw new NoSuchUserExistsException("Username doesn't exist");
            }

            var tokenRequest = new TokenDto {
                Id = user.Id,
                Username = user.Username
            };

            var token = _jwtToken.GenerateToken(tokenRequest);

            var loginResult = new LoginResult {
                Id = user.Id,
                Token = token
            };

            return loginResult;
        }
    }
}
