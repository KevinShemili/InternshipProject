using Application.Interfaces.Authentication;
using Application.Persistance;
using Application.UseCases.BorrowerJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.BorrowerJourney.Queries {

    public class GetBorrowerQuery : IRequest<BorrowerQueryResult> {
        public Guid Id { get; set; }
    }

    public class GetBorrowerQueryHandler : IRequestHandler<GetBorrowerQuery, BorrowerQueryResult> {

        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public GetBorrowerQueryHandler(IBorrowerRepository borrowerRepository, IMapper mapper, IStringLocalizer<LocalizationResources> localizer, IJwtToken jwtToken) {
            _borrowerRepository = borrowerRepository;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<BorrowerQueryResult> Handle(GetBorrowerQuery request, CancellationToken cancellationToken) {

            if (await _borrowerRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("BorrowerDoesntExist").Value);

            var borrower = await _borrowerRepository.GetByIdAsync(request.Id);
            var result = _mapper.Map<BorrowerQueryResult>(borrower);
            result.FirstName = borrower.User.FirstName;
            result.LastName = borrower.User.LastName;
            result.Email = borrower.User.Email;
            result.PhoneNumber = borrower.User.Prefix + " " + borrower.User.PhoneNumber;
            return result;
        }
    }

    public class GetBorrowerQueryValidator : AbstractValidator<GetBorrowerQuery> {
        public GetBorrowerQueryValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
