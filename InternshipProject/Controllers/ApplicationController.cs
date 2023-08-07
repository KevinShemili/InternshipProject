using Application.UseCases.ApplicationJourney.Commands;
using Application.UseCases.BorrowerJourney.Commands;
using Application.UseCases.BorrowerJourney.Queries;
using AutoMapper;
using Domain.Seeds;
using InternshipProject.Objects.Requests.ApplicationJourneyRequests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProject.Controllers {
    [ApiController]
    [Route("application-controller")]
    public class ApplicationController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ApplicationController(IMapper mapper, IMediator mediator) {
            _mapper = mapper;
            _mediator = mediator;
        }

        [Authorize(Policy = PermissionSeeds.CanAddApplication)]
        [HttpPost("borrowers/{id}")]
        public async Task<IActionResult> CreateApplication([FromRoute] Guid id, [FromBody] CreateApplicationRequest request) {
            var command = _mapper.Map<CreateApplicationCommand>(request);
            command.BorrowerId = id;

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("applications/{id}")]
        public async Task<IActionResult> GetApplication([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetBorrowerQuery {
                Id = id
            });
            return Ok(result);
        }

        [Authorize(Policy = $"{PermissionSeeds.CanUpdateApplication}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpPut("applications/{id}")]
        public async Task<IActionResult> UpdateApplication([FromRoute] Guid id, [FromBody] UpdateApplicationRequest request) {
            var command = _mapper.Map<UpdateApplicationCommand>(request);
            command.Id = id;

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [Authorize(Policy = $"{PermissionSeeds.CanDeleteApplication}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpDelete("applications/{id}")]
        public async Task<IActionResult> DeleteBorrower([FromRoute] Guid id) {

            _ = await _mediator.Send(new DeleteBorrowerCommand {
                Id = id,
            });

            return Ok();
        }
    }
}
