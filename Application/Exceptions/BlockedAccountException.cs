namespace Application.Exceptions {
    public class BlockedAccountException : Exception {
        public BlockedAccountException(string message) : base(message) {
        }
    }
}
