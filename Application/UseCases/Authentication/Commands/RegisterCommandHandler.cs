using Application.Persistance;
using Application.UseCases.Authentication.Common;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Authentication.Commands {
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResult> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public RegisterCommandHandler(IUserRepository userRepository, IMapper mapper) {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken) {
            
            var user = _mapper.Map<User>(request);

            _userRepository.Create(user);

            var returnResult = new RegisterResult {
                Id = user.Id,
                Username = user.Username
            };

            return returnResult;
        }
    }
}
