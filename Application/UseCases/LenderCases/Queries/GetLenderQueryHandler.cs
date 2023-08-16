using Application.Exceptions.ClientErrors;
using Application.Persistance;
using Application.UseCases.LenderCases.Results;
using AutoMapper;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LenderCases.Queries {
    public class GetLendersQuery : IRequest<LenderQueryResult> {
        public Guid LenderId { get; set; }
    }

    public class GetLendersQueryHandler : IRequestHandler<GetLendersQuery, LenderQueryResult> {

        private readonly IMapper _mapper;
        private readonly ILenderRepository _lenderRepository;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public GetLendersQueryHandler(ILenderRepository lenderRepository, IMapper mapper, IStringLocalizer<LocalizationResources> localization) {
            _lenderRepository = lenderRepository;
            _mapper = mapper;
            _localization = localization;
        }

        public async Task<LenderQueryResult> Handle(GetLendersQuery request, CancellationToken cancellationToken) {

            if (await _lenderRepository.ContainsAsync(request.LenderId) is false)
                throw new NotFoundException(_localization.GetString("LenderDoesntExist").Value);

            var lender = await _lenderRepository.GetByIdAsync(request.LenderId);
            return _mapper.Map<LenderQueryResult>(lender);
        }
    }

    public class GetLendersQueryValidator : AbstractValidator<GetLendersQuery> {
        public GetLendersQueryValidator() {
            RuleFor(x => x.LenderId)
                .NotEmpty().WithMessage("EmptyLenderId");
        }
    }
}
