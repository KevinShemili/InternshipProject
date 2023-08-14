using Application.Persistance;
using Application.UseCases.UserCases.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.UserCases.Queries {

    public class GetAllUsersQuery : IRequest<List<UserResult>> {
    }

    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserResult>> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(IMapper mapper, IUserRepository userRepository) {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<UserResult>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken) {

            var users = await _userRepository.GetAllAsync();

            return _mapper.Map<List<UserResult>>(users);
        }
    }

    public class GetAllUsersQueryValidator : AbstractValidator<GetAllUsersQuery> {
        public GetAllUsersQueryValidator() {

        }
    }
}
