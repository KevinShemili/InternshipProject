﻿using Application.Interfaces.Authentication;
using Application.Interfaces.Email;
using Application.Persistance;
using Application.Persistance.Common;
using Application.UseCases.Authentication.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.Authentication.Commands {

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
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterCommandHandler(IUserRepository userRepository, IMapper mapper, IHasherService hasherService, IMailBodyService mailBodyService, ITokenService recoveryTokenService, IMailService mailService, IUserVerificationAndResetRepository userVerificationAndResetRepository, IRoleRepository roleRepository, IStringLocalizer<LocalizationResources> localizer, IUnitOfWork unitOfWork) {
            _userRepository = userRepository;
            _mapper = mapper;
            _hasherService = hasherService;
            _mailBodyService = mailBodyService;
            _recoveryTokenService = recoveryTokenService;
            _mailService = mailService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _roleRepository = roleRepository;
            _localizer = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken) {

            if (await _userRepository.ContainsEmailAsync(request.Email) is true)
                throw new DuplicateException(_localizer.GetString("DuplicateEmail").Value);

            if (await _userRepository.ContainsUsernameAsync(request.Username) is true)
                throw new DuplicateException(_localizer.GetString("DuplicateUsername").Value);

            var tuple = _hasherService.HashPassword(request.Password);
            var hash = tuple.Item1;
            var salt = tuple.Item2;

            var user = _mapper.Map<User>(request);
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.IsEmailConfirmed = false;
            user.Roles = new List<Role> {
                await _roleRepository.GetByNameAsync(Domain.Seeds.RoleSeeds.RegisteredUser)
            };

            await _userRepository.CreateAsync(user);

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

            await _unitOfWork.SaveChangesAsync();

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
                .NotEmpty().WithMessage("EmptyUsername")
                .MinimumLength(8).WithMessage("UsernameMinimumLengthRestriction")
                .Matches(@"[0-9]+").WithMessage("UsernameNumberRestriction");

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("EmptyFirstName")
                .MaximumLength(25).WithMessage("FirstNameMaximumLengthRestriction");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("EmptyLastName")
                .MaximumLength(25).WithMessage("LastNameMaximumLengthRestriction");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("EmptyEmail")
                .EmailAddress().WithMessage("EmailFormatRestriction");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("EmptyPassword")
                .MinimumLength(8).WithMessage("PasswordMinimumLengthRestriction")
                .MaximumLength(14).WithMessage("PasswordMaximumLengthRestriction")
                .Matches(@"[A-Z]+").WithMessage("PasswordUppercaseLetterRestriction")
                .Matches(@"[a-z]+").WithMessage("PasswordLowercaseLetterRestriction")
                .Matches(@"[0-9]+").WithMessage("PasswordNumberRestriction");

            RuleFor(x => x.Prefix)
                .NotEmpty().WithMessage("EmptyPrefix")
                .Matches(@"^\+\d{2,3}$").WithMessage("PrefixFormatRestriction");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("EmptyPhoneNumber")
                .MinimumLength(8).WithMessage("PhoneNumberMinimumLengthRestriction")
                .MaximumLength(20).WithMessage("PhoneNumberMaximumLengthRestriction");
        }
    }
}
