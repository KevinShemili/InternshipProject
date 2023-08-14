using Application.Persistance;
using Application.UseCases.UserCases.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.UserCases.Queries {

    public class GetUserQuery : IRequest<UserResult> {
        public Guid Id { get; set; }
    }

    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserResult> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IMapper mapper, IUserRepository userRepository) {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserResult> Handle(GetUserQuery request, CancellationToken cancellationToken) {

            if (await _userRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException("");

            var user = await _userRepository.GetByIdAsync(request.Id);
            return _mapper.Map<UserResult>(user);
        }
    }

    public class GetUserQueryValidator : AbstractValidator<GetUserQuery> {
        public GetUserQueryValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
