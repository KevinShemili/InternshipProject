namespace Application.Interfaces.Authentication {
    public interface IJwtToken {
        string GenerateToken(Guid UserId, string username, IEnumerable<string> roles);
    }
}
