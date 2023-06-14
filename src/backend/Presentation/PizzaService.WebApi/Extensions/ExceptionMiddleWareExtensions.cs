using Microsoft.AspNetCore.Diagnostics;
using PizzaService.Application.Common;
using PizzaService.Domain.ErrorModels;
using System.Net;

namespace PizzaService.WebApi.Extensions
{
    public static class ExceptionMiddleWareExtensions
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerManager logger)
        {
            app.UseExceptionHandler(appError => {
                appError.Run(async context =>
                {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature != null)
                {
                    logger.LogError($"Something went wrong {contextFeature.Error}");
                    await context.Response.WriteAsync(new ErrorDetails()
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "Internal Server Error"
                    }.ToString());
                }
                });
            });
        }
    }
}
