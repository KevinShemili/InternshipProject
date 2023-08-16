using System.Net;

namespace Application.Exceptions.ServerErrors {
    public class ThirdPartyException : Exception {

        public static readonly HttpStatusCode status = HttpStatusCode.BadGateway;

        public ThirdPartyException(string message) : base(message) { }
    }
}
