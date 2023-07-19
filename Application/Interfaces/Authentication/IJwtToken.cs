namespace Application.Interfaces.Authentication {
    public interface IJwtToken {
        public string GenerateToken(Guid UserId, string username, IEnumerable<string> roles);
    }
}
