using Application.UseCases.ViewPermissions.Queries;
using AutoMapper;
using Infrastructure.Persistence.Seeds;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProject.Controllers {
    [Route("auth-management")]
    [ApiController]
    public class AuthManagement : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthManagement(IMediator mediator, IMapper mapper) {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpGet("permissions")]
        public async Task<IActionResult> GetPermissions() {
            var empty = new EmptyPermissionClassQuery();
            var result = await _mediator.Send(empty);
            return Ok(result);
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpGet("roles")]
        public async Task<IActionResult> GetRoles() {
            var empty = new EmptyRoleClassQuery();
            var result = await _mediator.Send(empty);
            return Ok(result);
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpGet("roles/{id}/permissions")]
        public void GetRolePermissions([FromRoute] Guid id) {

        }
    }
}
