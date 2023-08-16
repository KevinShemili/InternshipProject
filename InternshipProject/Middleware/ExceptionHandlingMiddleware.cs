using Application.Exceptions.ClientErrors;
using Application.Exceptions.ServerErrors;
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
            catch (NotFoundException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (FluentException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (UnauthorizedException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (ConflictException ex) {
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
            catch (BlockedException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (HttpRequestException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (FormatException ex) {
                _logger.LogError(ex.Message);
                await HandleExceptionAsync(context, ex);
            }
            catch (DatabaseException ex) {
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
                case NotFoundException noSuchUserExistsException:
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/404",
                        title = "Not Found",
                        status = (int)HttpStatusCode.NotFound,
                        detail = noSuchUserExistsException.Message
                    });
                    return context.Response.WriteAsync(result);

                case FluentException:
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


                case ConflictException duplicateException:
                    context.Response.StatusCode = (int)HttpStatusCode.Conflict;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/409",
                        title = "Conflict",
                        status = (int)HttpStatusCode.Conflict,
                        detail = duplicateException.Message
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

                case BlockedException exception:
                    context.Response.StatusCode = (int)HttpStatusCode.TooManyRequests;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/429",
                        title = "Too Many Requests",
                        status = (int)HttpStatusCode.TooManyRequests,
                        detail = exception.Message
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

                case FormatException formatException:
                    context.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/422",
                        title = "Unprocessable Entity",
                        status = (int)HttpStatusCode.UnprocessableEntity,
                        detail = formatException.Message
                    });
                    return context.Response.WriteAsync(result);

                case DatabaseException databaseException:
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/problem+json";
                    result = JsonConvert.SerializeObject(new {
                        type = "https://httpstatuses.io/500",
                        title = "Database Exception",
                        status = (int)HttpStatusCode.InternalServerError,
                        detail = databaseException.Message
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

            if (exception is FluentException validationException)
                errors = validationException.ErrorsDictionary;

            return errors;
        }
    }
}
