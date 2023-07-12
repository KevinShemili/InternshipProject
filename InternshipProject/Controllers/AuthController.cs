using Application.UseCases.Authentication;
using Application.UseCases.Authentication.Commands;
using Application.UseCases.Authentication.Common;
using Application.UseCases.Authentication.Queries;
using InternshipProject.Objects.Requests.AuthenticationRequests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProject.Controllers {
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase {

        private readonly IMediator _mediator;

        public AuthController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest) {
            // map registerRequest to registerCommand... (automap)
            var command = new RegisterCommand {
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName,
                Email = registerRequest.Email,
                Phone = registerRequest.Phone,
                Password = registerRequest.Password,
                Prefix = registerRequest.Prefix,
                Username = registerRequest.Username
            };

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LogIn([FromBody] LogInRequest logInRequest) {
            // map (automap)

            var query = new LoginQuery {
                Username = logInRequest.Username,
                Password = logInRequest.Password
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
