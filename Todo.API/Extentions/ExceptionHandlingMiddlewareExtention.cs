using Microsoft.AspNetCore.Builder;
using Todo.API.middlewares;

namespace Todo.API.Extentions
{
    public static class ExceptionHandlingMiddlewareExtention
    {
        public static void UseMyExceptionHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
