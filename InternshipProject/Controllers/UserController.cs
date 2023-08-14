using Application.UseCases.UserCases.Queries;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {
    public class UserController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper, IMediator mediator) {
            _mapper = mapper;
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Get all the registered users")]
        //[Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.CanReadOwnApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("users")]
        public async Task<IActionResult> GetUsers() {
            var result = await _mediator.Send(new GetAllUsersQuery { });
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
