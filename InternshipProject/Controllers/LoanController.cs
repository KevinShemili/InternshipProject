using Application.UseCases.LoanJourney.Commands;
using Application.UseCases.LoanJourney.Queries;
using AutoMapper;
using InternshipProject.Objects.Requests.LoanRequests;
using MediatR;
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

        [SwaggerOperation(Summary = "Approve application as loan")]
        [HttpPost("applications/{id}/loans")]
        public async Task<IActionResult> CreateLoan([FromRoute] Guid id, [FromBody] CreateLoanRequest request) {
            var command = _mapper.Map<CreateLoanCommand>(request);
            command.ApplicationId = id;

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get all loans")]
        [HttpGet("loans")]
        public async Task<IActionResult> GetAllLoans() {
            var result = await _mediator.Send(new GetAllLoansQuery { });

            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get loan by id")]
        [HttpGet("loans/{id}")]
        public async Task<IActionResult> GetLoanById([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetLoanQuery {
                Id = id
            });

            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get all loans of a borrower")]
        [HttpGet("borrowers/{id}/loans")]
        public async Task<IActionResult> GetBorrowerLoans([FromRoute] Guid id) {
            var result = await _mediator.Send(new GetBorrowerLoansQuery {
                BorrowerId = id
            });

            return Ok(result);
        }

        [SwaggerOperation(Summary = "Get a specific loan of a borrower")]
        [HttpGet("borrowers/{borrowerId}/loans/{loanId}")]
        public async Task<IActionResult> GetBorrowerLoan([FromRoute] Guid borrowerId, [FromRoute] Guid loanId) {
            var result = await _mediator.Send(new GetBorrowerLoanQuery {
                LoanId = loanId,
                BorrowerId = borrowerId
            });
            return Ok(result);
        }

        [SwaggerOperation(Summary = "Change loan status")]
        [HttpPatch("loans/{id}/change-status")]
        public async Task<IActionResult> ChangeLoanStatus([FromRoute] Guid id, [FromBody] Guid statusId) {
            var result = await _mediator.Send(new ChangeLoanStatusCommand {
                LoanId = id,
                StatusId = statusId
            });
            return Ok(result);
        }
    }
}
