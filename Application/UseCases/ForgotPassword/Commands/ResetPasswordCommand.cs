﻿using MediatR;

namespace Application.UseCases.ForgotPassword.Commands {
    public class ResetPasswordCommand : IRequest {
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
    }
}
