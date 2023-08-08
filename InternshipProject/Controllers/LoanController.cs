using Application.UseCases.ApplicationJourney.Commands;
using AutoMapper;
using Domain.Seeds;
using InternshipProject.Objects.Requests.ApplicationJourneyRequests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {
    [ApiController]
    [Route("api")]
    public class LoanController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public LoanController(IMapper mapper, IMediator mediator) {
            _mapper = mapper;
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Create new application")]
        [Authorize(Policy = PermissionSeeds.CanAddApplication)]
        [HttpPost("loans")]
        public async Task<IActionResult> CreateApplication([FromRoute] Guid id, [FromBody] CreateApplicationRequest request) {
            var command = _mapper.Map<CreateApplicationCommand>(request);
            command.BorrowerId = id;

            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
