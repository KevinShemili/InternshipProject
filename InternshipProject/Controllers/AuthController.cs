using Application.UseCases.Authentication.Commands;
using Application.UseCases.Authentication.Queries;
using AutoMapper;
using InternshipProject.Objects.Requests.AuthenticationRequests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProject.Controllers {
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthController(IMediator mediator, IMapper mapper) {
            _mediator = mediator;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest) {

            var registerCommand = _mapper.Map<RegisterCommand>(registerRequest);

            var result = await _mediator.Send(registerCommand);

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> LogIn([FromBody] LogInRequest logInRequest) {

            var loginQuery = _mapper.Map<LoginQuery>(logInRequest);

            var result = await _mediator.Send(loginQuery);

            return Ok(result);
        }
    }
}
