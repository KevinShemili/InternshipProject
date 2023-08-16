﻿using Application.UseCases.UserCases.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {

    [ApiController]
    [Route("api")]
    public class UserController : ControllerBase {

        private readonly IMediator _mediator;

        public UserController(IMediator mediator) {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Get all the registered users")]
        //[Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.CanReadOwnApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("users")]
        public async Task<IActionResult> GetUsers([FromQuery] string? filter,
                                                  [FromQuery] string? sortColumn,
                                                  [FromQuery] string? sortOrder,
                                                  [FromQuery] int pageSize,
                                                  [FromQuery] int page) {
            var result = await _mediator.Send(new GetAllUsersQuery {
                Filter = filter,
                SortColumn = sortColumn,
                SortOrder = sortOrder,
                PageSize = pageSize,
                Page = page
            });
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get user by id")]
        //[Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.CanReadOwnApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("users/{id}")]
        public async Task<IActionResult> GetUsers(Guid id) {
            var result = await _mediator.Send(new GetUserQuery {
                Id = id
            });
            return Ok(result);
        }
    }
}
