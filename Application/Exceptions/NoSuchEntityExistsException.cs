namespace Domain.Exceptions {
    public class NoSuchEntityExistsException : Exception {
        public NoSuchEntityExistsException(string message) : base(message) {
        }
    }
}
