using Domain.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace InternshipProject.Middleware {
    public class ExceptionHandlingMiddleware {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next) {
            _next = next;
        }

        public async Task Invoke(HttpContext context) {
            try {
                await _next(context);
            }
            catch(NoSuchUserExistsException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch(Exception ex) { }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex) {

            // Handle Exception by Defining the status code and the errror message.

            string? result = null;

            switch (ex) {
                case NoSuchUserExistsException noSuchUserExistsException:
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/404",
                        title = "Not Found",
                        status = (int)HttpStatusCode.NotFound,
                        detail = noSuchUserExistsException.message
                    });
                    return context.Response.WriteAsync(result);
                default:
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/500",
                        title = "Internal Server Error",
                        status = (int)HttpStatusCode.InternalServerError,
                        detail = "There was an internal server error. Please try again later."
                    });
                    return context.Response.WriteAsync(result);
            }
        }
    }
}
