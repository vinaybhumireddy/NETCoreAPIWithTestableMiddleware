# NETCoreAPIWithTestableMiddleware
 Test ASP.NET Core middleware
 Isolated Middleware for easy to test
Middleware can be tested in isolation with TestServer. It allows you to:

Instantiate an app pipeline containing only the components that you need to test.
Send custom requests to verify middleware behavior.
Advantages:

Requests are sent in-memory rather than being serialized over the network.
This avoids additional concerns, such as port management and HTTPS certificates.
Exceptions in the middleware can flow directly back to the calling test.
It's possible to customize server data structures, such as HttpContext, directly in the test.
Set up the TestServer
In the test project, create a test:

Build and start a host that uses TestServer.

Add any required services that the middleware uses.

Add a package reference to the project for the Microsoft.AspNetCore.TestHost NuGet package.

Configure the processing pipeline to use the middleware for the test.
 for more information https://learn.microsoft.com/en-us/aspnet/core/test/middleware?view=aspnetcore-7.0
