var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.Use(async (context, next) =>
{
    if (context.Request.Path == "/" && context.Request.Method == HttpMethods.Get)
    {
        context.Response.Redirect("/404.html");
        return;
    }

    await next();

    if (context.Response.StatusCode == StatusCodes.Status404NotFound && !context.Response.HasStarted)
    {
        var filePath = Path.Combine(app.Environment.ContentRootPath, "wwwroot", "404.html");
        if (File.Exists(filePath))
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            context.Response.StatusCode = StatusCodes.Status404NotFound;
            await context.Response.SendFileAsync(filePath);
        }
        else
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.WriteAsync("<html><body><h1>Hej! Ledte du efter <a href=\"https://www.pedersen.io\">www.pedersen.io</a>?</h1></body></html>");
        }
    }
});

app.UseAuthorization();

app.MapControllers();

app.Run();
