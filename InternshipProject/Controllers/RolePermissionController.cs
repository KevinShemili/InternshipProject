using Application.UseCases.Permissions.Commands;
using Application.UseCases.Permissions.Queries;
using Application.UseCases.Roles.Commands;
using Application.UseCases.Roles.Queries;
using Application.UseCases.ViewPermissions.Queries;
using AutoMapper;
using Infrastructure.Persistence.Seeds;
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

        [Authorize(Roles = Roles.SuperAdmin)]
        [HttpGet("permissions")]
        public async Task<IActionResult> GetPermissions() {
            var empty = new GetAllPermissionsQuery();
            var result = await _mediator.Send(empty);
            return Ok(result);
        }

        [Authorize(Roles = Roles.SuperAdmin)]
        [HttpGet("roles")]
        public async Task<IActionResult> GetRoles() {
            var empty = new GetRoleQuery();
            var result = await _mediator.Send(empty);
            return Ok(result);
        }

        [Authorize(Roles = Roles.SuperAdmin)]
        [HttpGet("roles/{id}/permissions")]
        public async Task<IActionResult> GetRolePermissions([FromRoute] Guid id) {
            var query = new RolePermissionsQuery { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [Authorize(Roles = Roles.SuperAdmin)]
        [HttpGet("users/{id}/roles")]
        public async Task<IActionResult> GetUserRoles([FromRoute] Guid id) {
            var query = new UserRoleQuery { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [Authorize(Roles = Roles.SuperAdmin)]
        [HttpPost("roles")]
        public async Task<IActionResult> CreateRole([FromBody] RoleRequest roleRequest) {
            var command = _mapper.Map<CreateRoleCommand>(roleRequest);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [Authorize(Roles = Roles.SuperAdmin)]
        [HttpPost("permissions")]
        public async Task<IActionResult> CreatePermission([FromBody] PermissionRequest permissionRequest) {
            var command = _mapper.Map<CreatePermissionCommand>(permissionRequest);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [Authorize(Roles = Roles.SuperAdmin)]
        [HttpPost("users/{id}/roles")]
        public async Task<IActionResult> AssignRole([FromRoute] Guid id, [FromBody] AssignationRequest assignationRequest) {
            var command = _mapper.Map<RoleAssignationCommand>(assignationRequest);
            command.UserId = id;
            await _mediator.Send(command);
            return Ok();
        }

        [Authorize(Roles = Roles.SuperAdmin)]
        [HttpPost("roles/{id}/permissions")]
        public async Task<IActionResult> AssignPermission([FromRoute] Guid id, [FromBody] AssignationRequest assignationRequest) {
            var command = _mapper.Map<PermissionAssignationCommand>(assignationRequest);
            command.RoleId = id;
            await _mediator.Send(command);
            return Ok();
        }
    }
}
