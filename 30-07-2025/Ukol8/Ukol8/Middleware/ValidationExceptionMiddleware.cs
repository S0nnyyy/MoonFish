using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;
using System.Text.Json;
using Ukol8.Models;

namespace Ukol8.Middleware
{
    public class ValidationExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ValidationExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            try
            {
                var task = _next(context);

                if (!task.IsCompletedSuccessfully)
                {
                    return task.ContinueWith(t =>
                    {
                        HandleException(context, t.Exception?.InnerException);
                    });
                }

                return task;
            }
            catch (Exception ex)
            {
                HandleException(context, ex);
                return Task.CompletedTask;
            }
        }

        private void HandleException(HttpContext context, Exception? ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            var response = new ValidationResponse();

            if (context.Items.TryGetValue("ModelState", out var obj) && obj is ModelStateDictionary modelState)
            {
                foreach (var state in modelState.Values)
                {
                    foreach (var error in state.Errors)
                    {
                        response.Errors.Add(error.ErrorMessage);
                    }
                }
            }
            else if (ex != null)
            {
                response.Errors.Add(ex.Message);
            }

            var json = JsonSerializer.Serialize(response);
            context.Response.WriteAsync(json).Wait();
        }
    }

    public static class ValidationExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseValidationExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ValidationExceptionMiddleware>();
        }
    }
}
