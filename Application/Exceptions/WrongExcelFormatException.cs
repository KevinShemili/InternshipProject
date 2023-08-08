namespace Application.Exceptions {
    public class WrongExcelFormatException : Exception {
        public WrongExcelFormatException(string message) : base(message) {
        }
    }
}
