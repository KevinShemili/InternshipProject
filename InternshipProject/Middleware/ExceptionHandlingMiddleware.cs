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
            catch (NoSuchEntityExistsException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (ValidationException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (UnauthorizedException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (InvalidPasswordException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (DuplicateException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (EmailServiceException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (TokenExpiredException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (ForbiddenException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (AutoMapper.AutoMapperMappingException ex) {
                await HandleExceptionAsync(context, ex);
            }
            catch (Exception ex) {
                await HandleExceptionAsync(context, ex);
            }

        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex) {

            // Handle Exception by Defining the status code and the errror message.

            string? result = null;

            switch (ex) {
                case NoSuchEntityExistsException noSuchUserExistsException:
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/404",
                        title = "Not Found",
                        status = (int)HttpStatusCode.NotFound,
                        detail = noSuchUserExistsException.message
                    });
                    return context.Response.WriteAsync(result);

                case ValidationException validationException:
                    context.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/422",
                        title = "Unprocessable Entity",
                        status = (int)HttpStatusCode.UnprocessableEntity,
                        details = GetErrors(ex)
                    });
                    return context.Response.WriteAsync(result);

                case UnauthorizedException unauthorizedException:
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/401",
                        title = "Unauthorized",
                        status = (int)HttpStatusCode.Unauthorized,
                        detail = unauthorizedException.Message
                    });
                    return context.Response.WriteAsync(result);

                case ForbiddenException forbidenException:
                    context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/403",
                        title = "Forbidden",
                        status = (int)HttpStatusCode.Forbidden,
                        detail = forbidenException.Message
                    });
                    return context.Response.WriteAsync(result);

                case InvalidPasswordException invalidPasswordException:
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/401",
                        title = "Unauthorized",
                        status = (int)HttpStatusCode.Unauthorized,
                        detail = invalidPasswordException.Message
                    });
                    return context.Response.WriteAsync(result);

                case DuplicateException duplicateException:
                    context.Response.StatusCode = (int)HttpStatusCode.Conflict;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/409",
                        title = "Conflict",
                        status = (int)HttpStatusCode.Conflict,
                        detail = duplicateException.Message
                    });
                    return context.Response.WriteAsync(result);

                case EmailServiceException emailServiceException:
                    context.Response.StatusCode = (int)HttpStatusCode.BadGateway;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/502",
                        title = "BadGateway",
                        status = (int)HttpStatusCode.BadGateway,
                        detail = emailServiceException.Message
                    });
                    return context.Response.WriteAsync(result);

                case TokenExpiredException tokenExpiredException:
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/400",
                        title = "BadGateway",
                        status = (int)HttpStatusCode.BadRequest,
                        detail = tokenExpiredException.Message
                    });
                    return context.Response.WriteAsync(result);

                case AutoMapper.AutoMapperMappingException automapperException:
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/500",
                        title = "Internal Server Error",
                        status = (int)HttpStatusCode.InternalServerError,
                        detail = automapperException.Message
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

        private static IReadOnlyDictionary<string, string[]>? GetErrors(Exception exception) {
            IReadOnlyDictionary<string, string[]>? errors = null;

            if (exception is ValidationException validationException)
                errors = validationException.ErrorsDictionary;

            return errors;
        }
    }
}
