using Application.UseCases.Authentication.Commands;
using Application.UseCases.ForgotPassword.Queries;
using Application.UseCases.ForgotUsername.Queries;
using Application.UseCases.GenerateRefreshToken;
using Application.UseCases.Permissions.Commands;
using Application.UseCases.ResendEmailVerification.Commands;
using Application.UseCases.Roles.Commands;
using AutoMapper;
using InternshipProject.Objects.Requests.AuthenticationRequests;
using InternshipProject.Objects.Requests.RolePermissionRequests;

namespace Application.Mapping {
    public class Mappings : Profile {
        public Mappings() {
            CreateMap<RegisterRequest, RegisterCommand>().ReverseMap();
            CreateMap<LogInRequest, LoginCommand>().ReverseMap();
            CreateMap<ResendVerificationEmailRequest, ResendEmailVerificationCommand>().ReverseMap();
            CreateMap<ForgotUsernameRequest, ForgotUsernameQuery>().ReverseMap();
            CreateMap<ForgotPasswordRequest, ForgotPasswordQuery>().ReverseMap();
            CreateMap<PermissionRequest, CreatePermissionCommand>().ReverseMap();
            CreateMap<RoleRequest, CreateRoleCommand>().ReverseMap();
            CreateMap<AssignationRequest, RoleAssignationCommand>()
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<AssignationRequest, PermissionAssignationCommand>()
                .ForMember(dest => dest.RoleId, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<RefreshTokenRequest, RefreshTokenCommand>().ReverseMap();
        }
    }
}
