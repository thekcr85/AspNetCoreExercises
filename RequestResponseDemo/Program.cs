var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
	Console.WriteLine($"Request to: {context.Request.Path}"); 
	await next();
});

app.Run(async context =>
{
	var path = context.Request.Path;

	if (path.StartsWithSegments("/hello"))
	{
		context.Response.ContentType = "text/plain"; 

		await context.Response.WriteAsync("Hello! Welcome to the HTTP Request & Response Demo.");
		await context.Response.WriteAsync("\nEnjoy exploring the endpoints!");
	}
	else if (path.StartsWithSegments("/time"))
	{
		context.Response.ContentType = "text/plain";

		await context.Response.WriteAsync($"Current server time is: {DateTime.Now}");
		await context.Response.WriteAsync("\nHave a great day!");
	}
	else if (path.StartsWithSegments("/request"))
	{
		context.Response.ContentType = "text/plain";

		await context.Response.WriteAsync("HTTP Request Info:\n");
		await context.Response.WriteAsync($"Method: {context.Request.Method}\n");
		await context.Response.WriteAsync($"Path: {context.Request.Path}\n");
		await context.Response.WriteAsync($"Query: {context.Request.QueryString}\n");
		await context.Response.WriteAsync("Headers:\n");

		foreach (var header in context.Request.Headers)
		{
			await context.Response.WriteAsync($"{header.Key}: {header.Value}\n");
		}
	}
	else if (path == "/")
	{
		context.Response.ContentType = "text/html";

		await context.Response.WriteAsync("<h2>HTTP Request & Response Demo</h2>");
		await context.Response.WriteAsync("<p>This is a simple demonstration of handling HTTP requests and responses using ASP.NET Core.</p>");
		await context.Response.WriteAsync("<ul>");
		await context.Response.WriteAsync("<li><a href=\"/hello\">/hello</a></li>");
		await context.Response.WriteAsync("<li><a href=\"/time\">/time</a></li>");
		await context.Response.WriteAsync("<li><a href=\"/request\">/request</a></li>");
		await context.Response.WriteAsync("</ul>");
	}
	else
	{
		context.Response.StatusCode = 404;
		context.Response.ContentType = "text/plain";
		await context.Response.WriteAsync("404 Not Found: The requested resource could not be found.");
	}
});

app.Run();