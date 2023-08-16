using Application.Persistance;
using Application.UseCases.BorrowerJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.BorrowerJourney.Queries {

    public class GetCompanyProfileQuery : IRequest<CompanyProfileResult> {
        public Guid BorrowerId { get; set; }
    }


    public class GetCompanyProfileQueryHandler : IRequestHandler<GetCompanyProfileQuery, CompanyProfileResult> {

        private readonly ICompanyProfileRepository _companyProfileRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;

        public GetCompanyProfileQueryHandler(IMapper mapper, IBorrowerRepository borrowerRepository, ICompanyProfileRepository companyProfileRepository) {
            _mapper = mapper;
            _borrowerRepository = borrowerRepository;
            _companyProfileRepository = companyProfileRepository;
        }

        public async Task<CompanyProfileResult> Handle(GetCompanyProfileQuery request, CancellationToken cancellationToken) {

            if (await _borrowerRepository.ContainsAsync(request.BorrowerId) is false)
                throw new NoSuchEntityExistsException("");

            var companyProfile = await _companyProfileRepository.GetByBorrowerAsync(request.BorrowerId);

            return _mapper.Map<CompanyProfileResult>(companyProfile);
        }
    }

    public class GetCompanyProfileQueryValidator : AbstractValidator<GetCompanyProfileQuery> {
        public GetCompanyProfileQueryValidator() {
            RuleFor(x => x.BorrowerId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }

}
