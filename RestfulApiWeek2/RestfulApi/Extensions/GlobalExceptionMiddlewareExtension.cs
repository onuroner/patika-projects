using RestfulApi.Middlewares;

namespace RestfulApi.Extensions
{
    public static class GlobalExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseGlobalException(this IApplicationBuilder app)
        {
            return app.UseMiddleware<GlobalExceptionMiddleware>();
        }
    }
}
