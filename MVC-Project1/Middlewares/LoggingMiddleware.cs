using System.Diagnostics;

namespace MVC_Project1.Middlewares
{
    public class LoggingMiddleware
    {
        RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Req => {context.Request.Method} /req url => {context.Request.Path}");
            await _next(context);
            stopwatch.Stop();
            Console.WriteLine($"res => {context.Response.StatusCode} , req time {stopwatch.ElapsedMilliseconds} ms");
        }
    }
    
}
