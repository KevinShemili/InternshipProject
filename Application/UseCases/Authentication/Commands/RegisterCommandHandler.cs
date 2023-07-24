using Application.Interfaces.Authentication;
using Application.Interfaces.Email;
using Application.Persistance;
using Application.UseCases.Authentication.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Authentication.Commands
{

    public class RegisterCommand : IRequest<RegisterResult> {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Prefix { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }

    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResult> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IHasherService _hasherService;
        private readonly IMailBodyService _mailBodyService;
        private readonly ITokenService _recoveryTokenService;
        private readonly IMailService _mailService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly IRoleRepository _roleRepository;

        public RegisterCommandHandler(IUserRepository userRepository, IMapper mapper, IHasherService hasherService, IMailBodyService mailBodyService, ITokenService recoveryTokenService, IMailService mailService, IUserVerificationAndResetRepository userVerificationAndResetRepository, IRoleRepository roleRepository) {
            _userRepository = userRepository;
            _mapper = mapper;
            _hasherService = hasherService;
            _mailBodyService = mailBodyService;
            _recoveryTokenService = recoveryTokenService;
            _mailService = mailService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _roleRepository = roleRepository;
        }

        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken) {

            if (await _userRepository.ContainsEmailAsync(request.Email) is true)
                throw new DuplicateException("Email already exists");

            if (await _userRepository.ContainsUsernameAsync(request.Username) is true)
                throw new DuplicateException("Username already exists");

            var tuple = _hasherService.HashPassword(request.Password);
            var hash = tuple.Item1;
            var salt = tuple.Item2;

            var user = _mapper.Map<User>(request);
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.IsEmailConfirmed = false;

            await _userRepository.CreateAsync(user);
            await _userRepository.AddRoleAsync(user.Id, await _roleRepository.GetByName(Domain.Seeds.Roles.RegisteredUser));

            var token = await _recoveryTokenService.GenerateVerificationTokenAsync();
            var tokenExpiry = DateTime.Now.AddMinutes(30);

            var body = await _mailBodyService.GetVerificationMailBodyAsync(request.Email, token);

            await _userVerificationAndResetRepository.CreateAsync(new UserVerificationAndReset {
                EmailVerificationToken = token,
                EmailVerificationTokenExpiry = tokenExpiry,
                UserEmail = request.Email,
            });

            var subject = "Verify Your Email";
            var mailData = new MailData(request.Email, subject, body);
            await _mailService.SendAsync(mailData, cancellationToken);

            var returnResult = new RegisterResult {
                Id = user.Id,
                Username = user.Username
            };

            return returnResult;
        }
    }

    public class RegisterCommandValidator : AbstractValidator<RegisterCommand> {
        public RegisterCommandValidator() {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username cannot be empty")
                .MinimumLength(8).WithMessage("Your username length must be at least 8 characters.")
                .Matches(@"[0-9]+").WithMessage("Your username must contain at least one number.");

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name cannot be empty")
                .MaximumLength(25).WithMessage("Your first name length must not exceed 25 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name cannot be empty")
                .MaximumLength(25).WithMessage("Your last name length must not exceed 25 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email format johndoe@mail.com");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Your password cannot be empty")
                .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                .MaximumLength(14).WithMessage("Your password length must not exceed 16.")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");

            RuleFor(x => x.Prefix)
                .NotEmpty()
                .WithMessage("Prefix cannot be empty")
                .Matches(@"^\+\d{2,3}$")
                .WithMessage("Prefix format +XX/+XXX");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone Number cannot be empty")
                .MinimumLength(8).WithMessage("More 8 characters required")
                .MaximumLength(20).WithMessage("PhoneNumber must not exceed 20 characters.");
        }
    }
}
