using Application.UseCases.BorrowerJourney.Commands;
using AutoMapper;
using Domain.Seeds;
using InternshipProject.Objects.Requests.BorrowerJourneyRequests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProject.Controllers {
    [ApiController]
    [Route("borrower-controller")]
    public class BorrowerController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BorrowerController(IMapper mapper, IMediator mediator) {
            _mapper = mapper;
            _mediator = mediator;
        }

        [Authorize(Policy = Permissions.IsRegistered)]
        [HttpPost("borrowers")]
        public async Task<IActionResult> CreateBorrower([FromHeader] string AccessToken, [FromBody] BorrowerRequest borrowerRequest) {
            var command = _mapper.Map<CreateBorrowerCommmand>(borrowerRequest);
            command.AccessToken = AccessToken;

            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
