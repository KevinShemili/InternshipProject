using AutoMapper;
using MediatR;
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


    }
}
