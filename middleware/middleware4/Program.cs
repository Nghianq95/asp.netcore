var app = WebApplication.Create();
app.UseMiddleware<TerminalMiddleware>();
app.Run();

//A middleware class in ASP.Net core simple a class that
// - Take a constructor with RequestDelegate
// - implements Invoke method taking HttpContext and return Task
// If you take a look at this code, it cannot be any simpler
// This is a terminal middleware. It does not invoke the subsequen middleware. It Just returns its own response.

public class TerminalMiddleware{
    public TerminalMiddleware(RequestDelegate next)
    {
        
    }

    public async Task Invoke(HttpContext context){
        await context.Response.WriteAsync("Hello World");
    }
}