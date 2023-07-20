namespace Domain.Exceptions {
    public class NoSuchEntityExistsException : Exception {
        public string message { get; set; }

        public NoSuchEntityExistsException(string message) : base(message) {
            this.message = message;
        }
    }
}
