using Application.UseCases.Authentication.Commands;
using Application.UseCases.Authentication.Queries;
using Application.UseCases.ResendEmailVerification;
using AutoMapper;
using InternshipProject.Objects.Requests.AuthenticationRequests;
using InternshipProject.Objects.Requests.EmailRequests;

namespace Application.Mapping {
    public class AuthenticationMapping : Profile {
        public AuthenticationMapping() {
            CreateMap<RegisterRequest, RegisterCommand>().ReverseMap();
            CreateMap<LogInRequest, LoginQuery>().ReverseMap();
            CreateMap<ResendVerificationEmailRequest, ResendEmailVerificationCommand>().ReverseMap();
        }
    }
}
