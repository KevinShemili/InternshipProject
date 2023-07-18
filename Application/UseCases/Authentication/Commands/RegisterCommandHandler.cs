using Application.Persistance;
using Application.Services;
using Application.UseCases.Authentication.Common;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.Authentication.Commands {
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResult> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IHasherService _hasherService;
        private readonly IActivateAccountEmailService _activateAccountEmailService;

        public RegisterCommandHandler(IUserRepository userRepository, IMapper mapper, IHasherService hasherService, IActivateAccountEmailService activateAccountEmailService) {
            _userRepository = userRepository;
            _mapper = mapper;
            _hasherService = hasherService;
            _activateAccountEmailService = activateAccountEmailService;
        }

        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken) {

            if (await _userRepository.ContainsEmail(request.Email) is true)
                throw new DuplicateException("Email already exists");

            if (await _userRepository.ContainsUsername(request.Username) is true)
                throw new DuplicateException("Username already exists");

            var tuple = _hasherService.HashPassword(request.Password);
            var hash = tuple.Item1;
            var salt = tuple.Item2;

            var user = _mapper.Map<User>(request);
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.IsEmailConfirmed = false;

            await _userRepository.CreateAsync(user);

            await _activateAccountEmailService.SendActivationEmail(request, cancellationToken);

            var returnResult = new RegisterResult {
                Id = user.Id,
                Username = user.Username
            };

            return returnResult;
        }


    }
}
