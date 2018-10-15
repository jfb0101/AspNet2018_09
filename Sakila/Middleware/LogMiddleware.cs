using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Sakila.Middleware {
    public class LogMiddleware {
        private readonly RequestDelegate next;
        private readonly LogMiddlewareOptions options;
        public LogMiddleware(RequestDelegate next,IOptions<LogMiddlewareOptions> options) {
            this.next = next;
            this.options = options.Value;
        }

        public async Task Invoke(HttpContext context) {
            var request = context.Request;
            var requestLogMessage = $"REQUEST:\n{request.Method} - {request.Path.Value}{request.QueryString}";

            File.AppendAllText(options.FilePath,$"{DateTime.Now.ToString("s")}\n{requestLogMessage}");

            await next.Invoke(context);
        }
    }

    public static class LogMiddlewareExtensions {
        public static IApplicationBuilder UseLogMiddleware(this IApplicationBuilder builder, LogMiddlewareOptions options) {
            return builder.UseMiddleware<LogMiddleware>(Options.Create(options));
        }
    }

    public class LogMiddlewareOptions {
        public string FilePath {get;set;}
    }
}