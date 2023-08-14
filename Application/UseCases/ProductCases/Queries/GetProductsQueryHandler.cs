using Application.Persistance;
using Application.UseCases.ProductCases.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.ProductCases.Queries {

    public class GetProductsQuery : IRequest<IEnumerable<ProductsResult>> {

    }

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductsResult>> {

        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper) {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductsResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken) {

            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductsResult>>(products);
        }
    }

    public class GetProductsQueryValidator : AbstractValidator<GetProductsQuery> {
        public GetProductsQueryValidator() {
        }
    }
}
