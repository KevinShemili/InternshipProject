using Application.UseCases.Permissions.Commands;
using Application.UseCases.Permissions.Queries;
using Application.UseCases.Roles.Commands;
using Application.UseCases.Roles.Queries;
using Application.UseCases.ViewPermissions.Queries;
using AutoMapper;
using Domain.Seeds;
using InternshipProject.Objects.Requests.RolePermissionRequests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProject.Controllers {
    [Route("auth-management")]
    [ApiController]
    public class RolePermissionController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public RolePermissionController(IMediator mediator, IMapper mapper) {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpGet("permissions")]
        public async Task<IActionResult> GetPermissions() {
            var result = await _mediator.Send(new GetAllPermissionsQuery());
            return Ok(result);
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpGet("roles")]
        public async Task<IActionResult> GetRoles() {
            var result = await _mediator.Send(new GetRoleQuery());
            return Ok(result);
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpGet("roles/{id}/permissions")]
        public async Task<IActionResult> GetRolePermissions([FromRoute] Guid id) {
            var query = new RolePermissionsQuery { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpGet("users/{id}/roles")]
        public async Task<IActionResult> GetUserRoles([FromRoute] Guid id) {
            var query = new UserRoleQuery { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpPost("roles")]
        public async Task<IActionResult> CreateRole([FromBody] RoleRequest roleRequest) {
            var command = _mapper.Map<CreateRoleCommand>(roleRequest);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpPost("permissions")]
        public async Task<IActionResult> CreatePermission([FromBody] PermissionRequest permissionRequest) {
            var command = _mapper.Map<CreatePermissionCommand>(permissionRequest);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpPost("users/{id}/roles")]
        public async Task<IActionResult> AssignRole([FromRoute] Guid id, [FromBody] AssignationRequest assignationRequest) {
            var command = _mapper.Map<RoleAssignationCommand>(assignationRequest);
            command.UserId = id;
            await _mediator.Send(command);
            return Ok();
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpPost("roles/{id}/permissions")]
        public async Task<IActionResult> AssignPermission([FromRoute] Guid id, [FromBody] AssignationRequest assignationRequest) {
            var command = _mapper.Map<PermissionAssignationCommand>(assignationRequest);
            command.RoleId = id;
            await _mediator.Send(command);
            return Ok();
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpDelete("roles/{id}")]
        public async Task<IActionResult> DeleteRole([FromRoute] Guid id) {
            var command = new DeleteRoleCommand { Id = id };
            await _mediator.Send(command);
            return Ok();
        }

        [Authorize(Policy = Permissions.IsSuperAdmin)]
        [HttpDelete("permissions/{id}")]
        public async Task<IActionResult> DeletePermission([FromRoute] Guid id) {
            var command = new DeletePermissionCommand { Id = id };
            await _mediator.Send(command);
            return Ok();
        }
    }
}
