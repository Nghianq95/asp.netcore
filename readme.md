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

## middleware 4
The simplest middleware

## middleware 5
Use `app.Map(MapMiddleware)` to configure your middleware pipeline to responsed only on specific url path.

## middleware 6
Nested `app.Map(show Request.Path)` and `Request.PathBase`

## middleware 7
Using app.MapWhen
Apart from the predicate logic, key differences between Map and MapWhen are that Map will add MapMiddleware to the pipeline (see here), while MapWhen will add MapWhenMiddleware to the pipeline (see here). The effect of this is that Map will update the Request.Path and Request.PathBase to account for branching based on path (trimming the matched path segment off Request.Path and appending it to Request.PathBase), while a seemingly equivalent MapWhen predicate will not. This affects anything downstream that uses the path, such as routing!
https://stackoverflow.com/questions/47997120/difference-between-map-and-mapwhen-branch-in-asp-net-core-middleware

## middleware 8
Using MapMiddleware and MapWhenMiddleware directily without using extensions

KO hieu lam

## middleware 9
Demonstrate the various ways you can inject dependency to your middleware class manually.

## middleware 10
Demonstrate how to ASP.NET core built in DI-mechanism to provide dependency for your middleware.

## middleware 11
Demonstrate that middleware is a singleton

## middleware 12
This sample is similar to Middleware 10 except that this one implement IMiddleware to create Factory-based middleware activation. This means that you can create a middleware that is not a singleton (either Transient or Scoped).

## middleware 13
Contrast the usage of MapWhen (which branch execution) and UseWhen (which doesn't branch execution) in configuring your Middleware.

## middleware 14
Demonstrate how to implement basic error handling mechanism and how to return error object (same for all api exceptions).