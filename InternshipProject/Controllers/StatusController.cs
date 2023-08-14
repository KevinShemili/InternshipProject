using Application.UseCases.StatusCases.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {

    [ApiController]
    [Route("api")]
    public class StatusController : ControllerBase {

        private readonly IMediator _mediator;

        public StatusController(IMediator mediator) {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Get loan statuses")]
        //[Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("loan-statuses")]
        public async Task<IActionResult> GetStatuses() {
            var result = await _mediator.Send(new GetLoanStatusesQuery { });
            return Ok(result);
        }
    }
}
