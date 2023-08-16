using Application.Interfaces.Pagination;
using Application.Persistance;
using Application.UseCases.BorrowerJourney.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using MediatR;
using System.Linq.Expressions;

namespace Application.UseCases.BorrowerJourney.Queries {

    public class GetUserBorrowersQuery : IRequest<PagedList<BorrowerQueryResult>> {
        public Guid UserId { get; set; }
        public string? Filter { get; set; }
        public string? SortColumn { get; set; }
        public string? SortOrder { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
    }

    public class GetUserBorrowersQueryHandler : IRequestHandler<GetUserBorrowersQuery, PagedList<BorrowerQueryResult>> {

        private readonly IUserRepository _userRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;
        private readonly IPaginationService<Borrower> _pagination;

        public GetUserBorrowersQueryHandler(IMapper mapper, IBorrowerRepository borrowerRepository, IUserRepository userRepository, IPaginationService<Borrower> pagination) {
            _mapper = mapper;
            _borrowerRepository = borrowerRepository;
            _userRepository = userRepository;
            _pagination = pagination;
        }

        public async Task<PagedList<BorrowerQueryResult>> Handle(GetUserBorrowersQuery request, CancellationToken cancellationToken) {

            if (await _userRepository.ContainsAsync(request.UserId) is false)
                throw new NoSuchEntityExistsException("");

            if (await _userRepository.HasBorrowersAsync(request.UserId) is false)
                return new PagedList<BorrowerQueryResult>();

            var borrowers = _borrowerRepository.GetIQueryable(request.UserId);

            var tuple = _pagination.Validate(request.Page, request.PageSize, borrowers.Count());
            request.Page = tuple.Item1;
            request.PageSize = tuple.Item2;

            borrowers = Filter(borrowers, request.Filter);
            borrowers = Sort(borrowers, request.SortOrder, request.SortColumn);
            var response = await _pagination.PaginateAsync(borrowers, request.Page, request.PageSize);

            return _mapper.Map<PagedList<BorrowerQueryResult>>(response);
        }

        private static IQueryable<Borrower> Filter(IQueryable<Borrower> borrowers, string? filter) {
            if (string.IsNullOrWhiteSpace(filter) is false)
                borrowers = borrowers.Where(x =>
                    x.CompanyName.Contains(filter) ||
                    x.VATNumber.ToString().Contains(filter) ||
                    x.FiscalCode.ToString().Contains(filter));

            return borrowers;
        }

        private static IQueryable<Borrower> Sort(IQueryable<Borrower> borrowers, string? sortOrder, string? sortColumn) {

            Expression<Func<Borrower, object>> key = sortColumn?.ToLower() switch {
                "companyName" => x => x.CompanyName,
                _ => x => x.Id
            };

            if (sortOrder?.ToLower() == "desc")
                return borrowers.OrderByDescending(key);
            else
                return borrowers.OrderBy(key);
        }
    }

    public class GetUserBorrowersQueryValidator : AbstractValidator<GetUserBorrowersQuery> {
        public GetUserBorrowersQueryValidator() {
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
