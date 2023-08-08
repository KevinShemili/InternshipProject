using Application.UseCases.ApplicationJourney.Commands;
using Application.UseCases.ApplicationJourney.Queries;
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
    public class ApplicationController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ApplicationController(IMapper mapper, IMediator mediator) {
            _mapper = mapper;
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Create new application")]
        [Authorize(Policy = PermissionSeeds.CanAddApplication)]
        [HttpPost("borrowers/{id}/applications")]
        public async Task<IActionResult> CreateApplication([FromRoute] Guid id, [FromBody] CreateApplicationRequest request) {
            var command = _mapper.Map<CreateApplicationCommand>(request);
            command.BorrowerId = id;

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get application info by id")]
        [Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("applications/{id}")]
        public async Task<IActionResult> GetApplication([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetApplicationQuery {
                Id = id
            });
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Edit application info (Loan Officer)")]
        [Authorize(Policy = $"{PermissionSeeds.CanUpdateApplication}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpPut("applications/{id}")]
        public async Task<IActionResult> UpdateApplication([FromRoute] Guid id, [FromBody] UpdateApplicationRequest request) {
            var command = _mapper.Map<UpdateApplicationCommand>(request);
            command.Id = id;

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Gets the applications of a borrower")]
        [Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.CanReadOwnApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("borrowers/{id}/applications")]
        public async Task<IActionResult> GetApplicationsByBorrower([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetApplicationsByBorrowerQuery {
                Id = id
            });
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get specific application of specific borrower")]
        [Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.CanReadOwnApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("borrowers/{borrowerId}/applications/{applicationId}")]
        public async Task<IActionResult> GetApplicationByBorrower([FromRoute] Guid borrowerId, [FromRoute] Guid applicationId) {
            var result = await _mediator.Send(new GetApplicationByBorrowerQuery {
                BorrowerId = borrowerId,
                ApplicationId = applicationId
            });
            return Ok(result);
        }
    }
}
