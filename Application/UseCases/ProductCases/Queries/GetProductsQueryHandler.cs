using Application.Interfaces.Pagination;
using Application.Persistance;
using Application.UseCases.ProductCases.Results;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;
using System.Linq.Expressions;

namespace Application.UseCases.ProductCases.Queries {

    public class GetProductsQuery : IRequest<PagedList<ProductsResult>> {
        public string? Filter { get; set; }
        public string? SortColumn { get; set; }
        public string? SortOrder { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
    }

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, PagedList<ProductsResult>> {

        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IPaginationService<Product> _pagination;

        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper, IPaginationService<Product> pagination) {
            _productRepository = productRepository;
            _mapper = mapper;
            _pagination = pagination;
        }

        public async Task<PagedList<ProductsResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken) {

            var products = _productRepository.GetIQueryable();

            var tuple = _pagination.Validate(request.Page, request.PageSize, products.Count());
            request.Page = tuple.Item1;
            request.PageSize = tuple.Item2;

            products = Filter(products, request.Filter);
            products = Sort(products, request.SortOrder, request.SortColumn);
            var response = await _pagination.PaginateAsync(products, request.Page, request.PageSize);

            return _mapper.Map<PagedList<ProductsResult>>(response);
        }

        private static IQueryable<Product> Filter(IQueryable<Product> products, string? filter) {
            if (string.IsNullOrWhiteSpace(filter) is false)
                products = products.Where(x =>
                    x.Name.Contains(filter) ||
                    x.ReferenceRate.ToString().Contains(filter) ||
                    x.FinanceMaxAmount.ToString().Contains(filter) ||
                    x.FinanceMinAmount.ToString().Contains(filter));

            return products;
        }

        private static IQueryable<Product> Sort(IQueryable<Product> products, string? sortOrder, string? sortColumn) {

            Expression<Func<Product, object>> key = sortColumn?.ToLower() switch {
                "name" => x => x.Name,
                "referenceRate" => x => x.ReferenceRate,
                "financeMaxAmount" => x => x.FinanceMaxAmount,
                "financeMinAmount" => x => x.FinanceMinAmount,
                _ => x => x.Id
            };

            if (sortOrder?.ToLower() == "desc")
                return products.OrderByDescending(key);
            else
                return products.OrderBy(key);
        }
    }

    public class GetProductsQueryValidator : AbstractValidator<GetProductsQuery> {
        public GetProductsQueryValidator() {
        }
    }
}
