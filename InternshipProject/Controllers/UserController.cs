using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProject.Controllers {
    public class UserController : ControllerBase {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper, IMediator mediator) {
            _mapper = mapper;
            _mediator = mediator;
        }
    }
}
