using Application.Persistance;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.ActivateAccount.Commands {
    public class ActivateAccountCommandHandler : IRequestHandler<ActivateAccountCommand> {

        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly IUserRepository _userRepository;

        public ActivateAccountCommandHandler(IUserVerificationAndResetRepository userVerificationAndResetRepository, IUserRepository userRepository) {
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _userRepository = userRepository;
        }

        public async Task Handle(ActivateAccountCommand request, CancellationToken cancellationToken) {

            var entity = await _userVerificationAndResetRepository.GetByEmailAsync(request.Email);
            var VerificationToken = entity.EmailVerificationToken;
            var VerificationTokenExpiry = entity.EmailVerificationTokenExpiry;

            if (VerificationToken is null)
                throw new ForbiddenException("Invalid token");

            if (VerificationTokenExpiry is null)
                throw new ForbiddenException("Invalid token");

            if (VerificationToken == request.Token
                && VerificationTokenExpiry > DateTime.Now)
                await _userRepository.ActivateAccount(request.Email);
            else if (VerificationToken == request.Token
                && VerificationTokenExpiry < DateTime.Now)
                throw new TokenExpiredException("Token has expired");
            else
                throw new ForbiddenException("Invalid token");
        }
    }
}
