using Application.Interfaces.Jobs;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InternshipProject.Controllers {
    [ApiController]
    [Route("api")]
    public class HangfireController : ControllerBase {

        private readonly IRecurringJobManager _jobManager;
        private readonly IJobService _jobService;

        public HangfireController(IJobService jobService, IRecurringJobManager jobManager) {
            _jobService = jobService;
            _jobManager = jobManager;
        }

        [SwaggerOperation(Summary = "Recurring company update")]
        [HttpGet("company-update")]
        public IActionResult RecurringCompanyUpdate() {

            _jobManager.AddOrUpdate("cpId", () => _jobService.RecurringCompanyUpdate(), Cron.Daily);
            return Ok();
        }
    }
}
