using Application.Interfaces.Services;
using Application.Persistance;
using Application.UseCases.Authentication.Common;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Authentication.Commands {
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResult> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IHasherService _hasherService;

        public RegisterCommandHandler(IUserRepository userRepository, IMapper mapper, IHasherService hasherService) {
            _userRepository = userRepository;
            _mapper = mapper;
            _hasherService = hasherService;
        }

        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken) {

            var tuple = _hasherService.HashPassword(request.Password);
            var hash = tuple.Item1;
            var salt = tuple.Item2;

            var user = _mapper.Map<User>(request);
            user.PasswordHash = hash;
            user.PasswordSalt = salt; 

            await _userRepository.CreateAsync(user);

            var returnResult = new RegisterResult {
                Id = user.Id,
                Username = user.Username
            };

            return returnResult;
        }
    }
}
