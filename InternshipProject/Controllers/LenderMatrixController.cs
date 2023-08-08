using Application.Interfaces.Excel;
using Application.UseCases.LenderMatrixCases.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {
    [ApiController]
    [Route("api")]
    public class LenderMatrixController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IExcelService _excelService;

        public LenderMatrixController(IMediator mediator, IExcelService excelService) {
            _mediator = mediator;
            _excelService = excelService;
        }

        [SwaggerOperation(Summary = "Create lender matrix")]
        [HttpPost("lender-matrix")]
        public async Task<IActionResult> CreateLenderMatrix(IFormFile file) {
            var flag = await _mediator.Send(new CreateLenderMatrixCommand {
                File = file
            });


            return Ok(flag);
        }

        [SwaggerOperation(Summary = "Generate lender matrix template")]
        [HttpGet("lender-matrix/generate")]
        public IActionResult GenerateLenderMatrix() {
            return _excelService.GenerateMatrixTemplate();
        }
    }
}
