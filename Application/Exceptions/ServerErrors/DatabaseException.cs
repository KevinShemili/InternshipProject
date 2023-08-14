namespace Application.Exceptions.ServerErrors {
    public class DatabaseException : Exception {
        public DatabaseException(string message) : base(message) { }
    }
}
