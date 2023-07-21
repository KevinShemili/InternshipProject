using Application.Interfaces.Email;
using Application.Persistance;
using Application.Services;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.ForgotUsername.Queries {

    public class ForgotUsernameQuery : IRequest {
        public string Email { get; set; } = null!;
    }

    public class ForgotUsernameQueryHandler : IRequestHandler<ForgotUsernameQuery> {

        private readonly IUserRepository _userRepository;
        private readonly IMailService _mailService;
        private readonly IMailBodyService _mailBodyService;

        public ForgotUsernameQueryHandler(IUserRepository userRepository, IMailService mailService, IMailBodyService mailBodyService) {
            _userRepository = userRepository;
            _mailService = mailService;
            _mailBodyService = mailBodyService;
        }

        public async Task Handle(ForgotUsernameQuery request, CancellationToken cancellationToken) {

            var entity = await _userRepository.GetByEmailAsync(request.Email);

            if (entity == null)
                throw new NoSuchEntityExistsException("User does not exist");

            var body = await _mailBodyService.GetForgotUsernameMailBodyAsync(entity.Username);
            string subject = "Forgot Username";

            var mailData = new MailData(request.Email, subject, body);

            await _mailService.SendAsync(mailData, cancellationToken);
        }
    }

    public class ForgotUsernameQueryValidator : AbstractValidator<ForgotUsernameQuery> {
        public ForgotUsernameQueryValidator() {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email format johndoe@mail.com");
        }
    }
}
