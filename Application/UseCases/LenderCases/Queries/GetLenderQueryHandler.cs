using Application.Persistance;
using Application.UseCases.LenderCases.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LenderCases.Queries {
    public class GetLendersQuery : IRequest<LenderQueryResult> {
        public Guid Id { get; set; }
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

            if (await _lenderRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException("");

            var lender = await _lenderRepository.GetByIdAsync(request.Id);
            return _mapper.Map<LenderQueryResult>(lender);
        }
    }

    public class GetLendersQueryValidator : AbstractValidator<GetLendersQuery> {
        public GetLendersQueryValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
