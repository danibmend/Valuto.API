using JesusEmNos.Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(
            RequestDelegate next,
            ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (AntiCorruptException exception)
            {
                await ReturnException(context, StatusCodes.Status502BadGateway, exception.Message, exception.InnerException?.Message);
            }
            catch (BusinessException exception)
            {
                await ReturnException(context, StatusCodes.Status422UnprocessableEntity, exception.Message, exception.InnerException?.Message);
            }
            catch (DataBaseException exception)
            {
                await ReturnException(context, StatusCodes.Status503ServiceUnavailable, exception.Message, exception.InnerException?.Message);
            }
            catch (NotFoundException exception)
            {
                await ReturnException(context, StatusCodes.Status404NotFound, exception.Message, exception.InnerException?.Message);
            }
            catch (ValidationException exception)
            {
                await ReturnException(context, StatusCodes.Status400BadRequest, exception.Message, exception.InnerException?.Message);
            }
            catch (Exception exception)
            {
                await ReturnException(context, StatusCodes.Status500InternalServerError, exception.Message, exception.InnerException?.Message);
            }
        }

        private async Task ReturnException(HttpContext context, int statusCode, string mensagem, string? innerException)
        {
            _logger.LogError(mensagem);

            var problemDetails = new ProblemDetails
            {
                Status = statusCode,
                Title = mensagem,
                Detail = innerException
            };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
        }
    }
}
