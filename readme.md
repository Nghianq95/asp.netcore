# Dependency Injection
## DI1
Singleton, Transient, Scoped

## DI2
IServiceProvider

# Middleware
## middleware 1
Using `IApplicationBuilder Use`, an extension method for adding middleware and `IApplicationBuilder Run`

## middleware 2
Passing information from one middleware to another using `HttpContext.Items`

## middleware 3
As a general rule, only one of your Middleware should write to Response in an execution path. This sample shows how to work around this by buffering the Response.
e.g
If path / involves the execution of Middleware1, Middleware2 and Middleware3, only one of these should write to Response.
