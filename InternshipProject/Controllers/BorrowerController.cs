using Application.UseCases.BorrowerJourney.Commands;
using Application.UseCases.BorrowerJourney.Queries;
using AutoMapper;
using InternshipProject.Objects.Requests.BorrowerJourneyRequests;
using MediatR;
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

        //[Authorize(Policy = PermissionSeeds.CanAddBorrower)]
        [HttpPost("borrowers")]
        public async Task<IActionResult> CreateBorrower([FromHeader] string AccessToken, [FromBody] BorrowerRequest borrowerRequest) {
            var command = _mapper.Map<CreateBorrowerCommmand>(borrowerRequest);
            command.AccessToken = AccessToken;

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        //[Authorize(Policy = $"{DefinedPermissions.CanReadBorrowers}, {DefinedPermissions.IsSuperAdmin}")]
        [HttpGet("borrowers/{id}")]
        public async Task<IActionResult> GetBorrower([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetBorrowerQuery {
                Id = id
            });
            return Ok(result);
        }

        //[Authorize(Policy = $"{DefinedPermissions.CanUpdateBorrower}, {DefinedPermissions.IsSuperAdmin}")]
        [HttpPut("borrowers/{id}")]
        public async Task<IActionResult> UpdateBorrower([FromRoute] Guid id, [FromBody] BorrowerRequest borrowerRequest) {
            var command = _mapper.Map<UpdateBorrowerCommand>(borrowerRequest);
            command.Id = id;

            _ = await _mediator.Send(command);
            return Ok();
        }

        //[Authorize(Policy = $"{DefinedPermissions.CanDeleteBorrower}, {DefinedPermissions.IsSuperAdmin}")]
        [HttpDelete("borrowers/{id}")]
        public async Task<IActionResult> DeleteBorrower([FromRoute] Guid id) {

            _ = await _mediator.Send(new DeleteBorrowerCommand {
                Id = id,
            });

            return Ok();
        }

        //[Authorize(Policy = $"{PermissionSeeds.CanDeleteBorrower}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("users/{id}/borrowers")]
        public async Task<IActionResult> GetBorrowersByUser([FromRoute] Guid id) {

            var borrowers = await _mediator.Send(new GetUserBorrowersQuery {
                UserId = id,
            });

            return Ok(borrowers);
        }

        //[Authorize(Policy = $"{PermissionSeeds.CanDeleteBorrower}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("borrowers/{id}/company-profile")]
        public async Task<IActionResult> GetCompanyProfile([FromRoute] Guid id) {

            var companyProfile = await _mediator.Send(new GetCompanyProfileQuery {
                BorrowerId = id,
            });

            return Ok(companyProfile);
        }
    }
}
