using Application.Persistance;
using Application.UseCases.BorrowerJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.BorrowerJourney.Queries {

    public class GetUserBorrowersQuery : IRequest<IEnumerable<BorrowerQueryResult>> {
        public Guid UserId { get; set; }
    }

    public class GetUserBorrowersQueryHandler : IRequestHandler<GetUserBorrowersQuery, IEnumerable<BorrowerQueryResult>> {

        private readonly IUserRepository _userRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;

        public GetUserBorrowersQueryHandler(IMapper mapper, IBorrowerRepository borrowerRepository, IUserRepository userRepository) {
            _mapper = mapper;
            _borrowerRepository = borrowerRepository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<BorrowerQueryResult>> Handle(GetUserBorrowersQuery request, CancellationToken cancellationToken) {

            if (await _userRepository.ContainsAsync(request.UserId) is false)
                throw new NoSuchEntityExistsException("");

            if (await _userRepository.HasBorrowersAsync(request.UserId) is false)
                return new List<BorrowerQueryResult>().AsEnumerable();

            var borrowers = await _borrowerRepository.GetUserBorrowers(request.UserId);

            return _mapper.Map<IEnumerable<BorrowerQueryResult>>(borrowers);
        }
    }

    public class GetUserBorrowersQueryValidator : AbstractValidator<GetUserBorrowersQuery> {
        public GetUserBorrowersQueryValidator() {
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
