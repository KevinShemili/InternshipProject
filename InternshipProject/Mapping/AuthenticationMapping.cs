using Application.UseCases.Authentication.Commands;
using Application.UseCases.Authentication.Queries;
using AutoMapper;
using InternshipProject.Objects.Requests.AuthenticationRequests;

namespace Application.Mapping {
    public class AuthenticationMapping : Profile {
        public AuthenticationMapping() {
            CreateMap<RegisterRequest, RegisterCommand>().ReverseMap();
            CreateMap<LogInRequest, LoginQuery>().ReverseMap();
        }
    }
}
