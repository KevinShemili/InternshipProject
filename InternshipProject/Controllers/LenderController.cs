using Application.UseCases.LenderCases.Queries;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {

    [ApiController]
    [Route("api")]
    public class LenderController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public LenderController(IMapper mapper, IMediator mediator) {
            _mapper = mapper;
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Get eligible lenders")]
        [AllowAnonymous]
        [HttpGet("applications/{id}/eligible-lenders")]
        public async Task<IActionResult> GetEligibleLenders([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetEligibleLendersQuery {
                Id = id
            });
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get all lenders")]
        [AllowAnonymous]
        [HttpGet("lenders")]
        public async Task<IActionResult> GetAllLenders() {
            var result = await _mediator.Send(new GetAllLendersQuery { });
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get lender by id")]
        [AllowAnonymous]
        [HttpGet("lenders/{id}")]
        public async Task<IActionResult> GetLenderById([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetLendersQuery {
                Id = id
            });
            return Ok(result);
        }
    }
}
