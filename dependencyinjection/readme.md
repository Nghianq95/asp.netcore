# Day 1
## Singleton, Scoped, Transient

### Singleton
Singleton objects are the same for every request.

### Scoped
Scoped objects are the same with a request, but different accoss different requests.

### Transient
Transient objects are always different; a new instance is provided to every controller and every service.

# Day 2
## IServiceProvider

`IServiceProvider` is a service locator. It allows you to obtain objects from dependency injection system. It is considered a bad pratice in common scenario.

It is better to be explicit of your dependency in your constructor e.g. 
`MyObject(ILogger<MyObject> logger, IStringLocalizer<MyObject>)` than using `MyObject(IServiceProvider provider)` and obtain those object via the provider.

However when you encounter situation where using a service locator is  needed, `IServiceProvider` is there for you.
