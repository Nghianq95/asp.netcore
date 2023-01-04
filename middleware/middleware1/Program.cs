var app = WebApplication.Create();

// The order of these things are important.
app.Use(async (context, next) => {
    context.Items["Content"] += "[1] ---- \n";
    await next(context);
    context.Items["Content"] += "[5] ---- \n";
    await context.Response.WriteAsync(context.Items["Content"] as string);
});

app.Use(async (context, next) => {
    context.Items["Content"] += "[2] Hello World \n";
    await next(context);
    context.Items["Content"] += "[4] \n";
});

app.Run(context =>{
    context.Items["Content"] += "[3] --- \n";
    return Task.CompletedTask;
});

app.Run();