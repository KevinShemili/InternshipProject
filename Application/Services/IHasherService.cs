namespace Application.Services {
    public interface IHasherService {
        public bool VerifyPassword(string inputPassword, string passwordHash, string passwordSalt);
        public Tuple<string, string> HashPassword(string password);
    }
}
