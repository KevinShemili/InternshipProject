using Application.UseCases.CompanyTypeCases.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {
    public class CompanyTypeController : ControllerBase {

        private readonly IMediator _mediator;

        public CompanyTypeController(IMediator mediator) {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Get company types")]
        //[Authorize(Policy = $"{PermissionSeeds.CanReadApplications}, {PermissionSeeds.IsSuperAdmin}")]
        [HttpGet("company-types")]
        public async Task<IActionResult> GetCompanyTypes() {
            var result = await _mediator.Send(new GetAllCompanyTypesQuery { });
            return Ok(result);
        }
    }
}
