using Application.Exceptions;
using Domain.Exceptions;
using InternshipProject.Localizations;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System.Net;

namespace InternshipProject.Middleware {
    public class ExceptionHandlingMiddleware {

        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger, IStringLocalizer<LocalizationResources> localization) {
            _next = next;
            _logger = logger;
            _localization = localization;
        }

        public async Task Invoke(HttpContext context) {
            try {
                await _next(context);
            }
            catch (NoSuchEntityExistsException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (ValidationException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (UnauthorizedException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (InvalidPasswordException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (DuplicateException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (EmailServiceException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (TokenExpiredException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (ForbiddenException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (AutoMapper.AutoMapperMappingException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (BlockedAccountException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (EmailAlreadyVerifiedException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (HttpRequestException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (Exception ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex) {

            // Handle Exception by Defining the status code and the errror message.

            string? result;

            switch (ex) {
                case NoSuchEntityExistsException noSuchUserExistsException:
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/404",
                        title = "Not Found",
                        status = (int)HttpStatusCode.NotFound,
                        detail = noSuchUserExistsException.Message
                    });
                    return context.Response.WriteAsync(result);

                case ValidationException:
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
                        title = "Bad Gateway",
                        status = (int)HttpStatusCode.BadGateway,
                        detail = emailServiceException.Message
                    });
                    return context.Response.WriteAsync(result);

                case TokenExpiredException tokenExpiredException:
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/400",
                        title = "Bad Request",
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

                case BlockedAccountException blockedAccountException:
                    context.Response.StatusCode = (int)HttpStatusCode.TooManyRequests;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/429",
                        title = "Too Many Requests",
                        status = (int)HttpStatusCode.TooManyRequests,
                        detail = blockedAccountException.Message
                    });
                    return context.Response.WriteAsync(result);

                case EmailAlreadyVerifiedException emailAlreadyVerifiedException:
                    context.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/422",
                        title = "Unprocessable Entity",
                        status = (int)HttpStatusCode.UnprocessableEntity,
                        detail = emailAlreadyVerifiedException.Message
                    });
                    return context.Response.WriteAsync(result);

                case HttpRequestException httpRequestException:
                    context.Response.StatusCode = (int)HttpStatusCode.ServiceUnavailable;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/503",
                        title = "Service Unavailable",
                        status = (int)HttpStatusCode.ServiceUnavailable,
                        detail = httpRequestException.Message
                    });
                    return context.Response.WriteAsync(result);

                default:
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/500",
                        title = "Internal Server Error",
                        status = (int)HttpStatusCode.InternalServerError,
                        detail = _localization.GetString("InternalError").Value
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
