using Application.Persistance;
using Application.UseCases.BlockedAccounts.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.BlockedAccounts.Queries {

    public class BlockedAccountsQuery : IRequest<IEnumerable<BlockedAccountResult>> {
    }


    public class BlockedAccountsQueryHandler : IRequestHandler<BlockedAccountsQuery, IEnumerable<BlockedAccountResult>> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public BlockedAccountsQueryHandler(IMapper mapper, IUserRepository userRepository) {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<BlockedAccountResult>> Handle(BlockedAccountsQuery request, CancellationToken cancellationToken) {
            var users = await _userRepository.GetBlockedAccountsAsync();
            return _mapper.Map<IEnumerable<BlockedAccountResult>>(users);
        }
    }

    public class BlockedAccountsQueryValidator : AbstractValidator<BlockedAccountsQuery> {
        public BlockedAccountsQueryValidator() { }
    }
}
