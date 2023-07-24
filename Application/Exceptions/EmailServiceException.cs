namespace Domain.Exceptions {
    public class EmailServiceException : Exception {
        public EmailServiceException(string message) : base(message) {
        }
    }
}
