using System.Net;

namespace Application.Exceptions.ClientErrors {

    public class InvalidInputException : Exception {

        public static readonly HttpStatusCode status = HttpStatusCode.BadRequest;

        public InvalidInputException(string message) : base(message) { }
    }
}
