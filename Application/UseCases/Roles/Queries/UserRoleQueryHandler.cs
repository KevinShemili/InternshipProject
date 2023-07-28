using Application.Persistance;
using Application.UseCases.ViewRoles.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Roles.Queries {

    public class UserRoleQuery : IRequest<List<RoleResult>> {
        public Guid Id { get; set; }
    }

    public class UserRoleQueryHandler : IRequestHandler<UserRoleQuery, List<RoleResult>> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserRoleQueryHandler(IMapper mapper, IUserRepository userRepository) {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<RoleResult>> Handle(UserRoleQuery request, CancellationToken cancellationToken) {
            var roles = await _userRepository.GetRolesAsync(request.Id);

            var result = _mapper.Map<List<RoleResult>>(roles.ToList());
            return result;
        }
    }

    public class UserRoleQueryValidator : AbstractValidator<UserRoleQuery> {
        public UserRoleQueryValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
