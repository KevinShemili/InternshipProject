namespace Application.UseCases.Authentication.Common {
    public class RegisterResult {
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
    }
}
