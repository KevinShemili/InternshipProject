using Application.UseCases.LenderCases.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {

    [ApiController]
    [Route("api")]
    public class LenderController : ControllerBase {

        private readonly IMediator _mediator;

        public LenderController(IMediator mediator) {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Get eligible lenders")]
        [AllowAnonymous]
        [HttpGet("applications/{id}/eligible-lenders")]
        public async Task<IActionResult> GetEligibleLenders([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetEligibleLendersQuery {
                ApplicationId = id
            });
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get all lenders")]
        [AllowAnonymous]
        [HttpGet("lenders")]
        public async Task<IActionResult> GetAllLenders([FromQuery] string? filter,
                                                       [FromQuery] string? sortColumn,
                                                       [FromQuery] string? sortOrder,
                                                       [FromQuery] int pageSize,
                                                       [FromQuery] int page) {

            var result = await _mediator.Send(new GetAllLendersQuery {
                Filter = filter,
                SortColumn = sortColumn,
                SortOrder = sortOrder,
                PageSize = pageSize,
                Page = page
            });
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get lender by id")]
        [AllowAnonymous]
        [HttpGet("lenders/{id}")]
        public async Task<IActionResult> GetLenderById([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetLendersQuery {
                LenderId = id
            });
            return Ok(result);
        }
    }
}
