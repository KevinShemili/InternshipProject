using Application.Persistance;
using Application.UseCases.LoanJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.LoanJourney.Queries {

    public class GetLoanQuery : IRequest<LoanResult> {
        public Guid Id { get; set; }
    }

    public class GetLoanQueryHandler : IRequestHandler<GetLoanQuery, LoanResult> {

        private readonly ILoanRepository _loanRepository;
        private readonly IMapper _mapper;

        public GetLoanQueryHandler(IMapper mapper, ILoanRepository loanRepository) {
            _mapper = mapper;
            _loanRepository = loanRepository;
        }

        public async Task<LoanResult> Handle(GetLoanQuery request, CancellationToken cancellationToken) {

            if (await _loanRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException("");

            var loan = await _loanRepository.GetByIdAsync(request.Id);

            return _mapper.Map<LoanResult>(loan);
        }
    }

    public class GetLoanQueryValidator : AbstractValidator<GetLoanQuery> {
        public GetLoanQueryValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
