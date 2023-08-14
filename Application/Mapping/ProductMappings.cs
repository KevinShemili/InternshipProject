using Application.UseCases.ProductCases.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class ProductMappings : Profile {
        public ProductMappings() {

            CreateMap<ProductsResult, Product>().ReverseMap();

        }
    }
}
