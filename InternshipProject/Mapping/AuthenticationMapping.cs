using Application.UseCases.Authentication.Commands;
using Application.UseCases.Authentication.Queries;
using Application.UseCases.ForgotPassword.Queries;
using Application.UseCases.ForgotUsername.Queries;
using Application.UseCases.ResendEmailVerification.Commands;
using AutoMapper;
using InternshipProject.Objects.Requests.AuthenticationRequests;

namespace Application.Mapping {
    public class AuthenticationMapping : Profile {
        public AuthenticationMapping() {
            CreateMap<RegisterRequest, RegisterCommand>().ReverseMap();
            CreateMap<LogInRequest, LoginQuery>().ReverseMap();
            CreateMap<ResendVerificationEmailRequest, ResendEmailVerificationCommand>().ReverseMap();
            CreateMap<ForgotUsernameRequest, ForgotUsernameQuery>().ReverseMap();
            CreateMap<ForgotPasswordRequest, ForgotPasswordQuery>().ReverseMap();
        }
    }
}
