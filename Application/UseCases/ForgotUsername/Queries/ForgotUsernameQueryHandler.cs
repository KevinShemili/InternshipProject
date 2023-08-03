using Application.Interfaces.Email;
using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ForgotUsername.Queries {

    public class ForgotUsernameQuery : IRequest<bool> {
        public string Email { get; set; } = null!;
    }

    public class ForgotUsernameQueryHandler : IRequestHandler<ForgotUsernameQuery, bool> {

        private readonly IUserRepository _userRepository;
        private readonly IMailService _mailService;
        private readonly IMailBodyService _mailBodyService;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public ForgotUsernameQueryHandler(IUserRepository userRepository, IMailService mailService, IMailBodyService mailBodyService, IStringLocalizer<LocalizationResources> localizer) {
            _userRepository = userRepository;
            _mailService = mailService;
            _mailBodyService = mailBodyService;
            _localizer = localizer;
        }

        public async Task<bool> Handle(ForgotUsernameQuery request, CancellationToken cancellationToken) {

            var entity = await _userRepository.GetByEmailAsync(request.Email);

            if (entity == null)
                throw new NoSuchEntityExistsException(_localizer.GetString("EmailDoesntExist"));

            var body = await _mailBodyService.GetForgotUsernameMailBodyAsync(entity.Username);
            string subject = "Forgot Username";

            var mailData = new MailData(request.Email, subject, body);

            await _mailService.SendAsync(mailData, cancellationToken);
            return true;
        }
    }

    public class ForgotUsernameQueryValidator : AbstractValidator<ForgotUsernameQuery> {
        public ForgotUsernameQueryValidator() {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("EmptyEmail")
                .EmailAddress().WithMessage("EmailFormatRestriction");
        }
    }
}
