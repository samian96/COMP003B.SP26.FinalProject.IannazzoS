namespace COMP003B.SP26.FinalProject.IannazzoS.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        // should control requests and responses in the consol app
        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"[Response] {context.Response.StatusCode}");
        }
    }
}
