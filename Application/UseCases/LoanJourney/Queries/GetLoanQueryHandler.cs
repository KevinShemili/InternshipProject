using Application.Exceptions.ClientErrors;
using Application.Persistance;
using Application.UseCases.LoanJourney.Results;
using AutoMapper;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LoanJourney.Queries {

    public class GetLoanQuery : IRequest<LoanResult> {
        public Guid LoanId { get; set; }
    }

    public class GetLoanQueryHandler : IRequestHandler<GetLoanQuery, LoanResult> {

        private readonly ILoanRepository _loanRepository;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public GetLoanQueryHandler(IMapper mapper,
                                   ILoanRepository loanRepository,
                                   IStringLocalizer<LocalizationResources> localization) {
            _mapper = mapper;
            _loanRepository = loanRepository;
            _localization = localization;
        }

        public async Task<LoanResult> Handle(GetLoanQuery request, CancellationToken cancellationToken) {

            if (await _loanRepository.ContainsAsync(request.LoanId) is false)
                throw new NotFoundException(_localization.GetString("LoanDoesntExist").Value);

            var loan = await _loanRepository.GetByIdAsync(request.LoanId);

            return _mapper.Map<LoanResult>(loan);
        }
    }

    public class GetLoanQueryValidator : AbstractValidator<GetLoanQuery> {
        public GetLoanQueryValidator() {
            RuleFor(x => x.LoanId)
                .NotEmpty().WithMessage("EmptyLoanId");
        }
    }
}
