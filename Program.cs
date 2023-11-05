using Microsoft.EntityFrameworkCore;
using CustomerAPI.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//registering DbContext Models/CustomersContext to add generate migration in local DB
builder.Services.AddDbContext<CustomerContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Connection")));

builder.Services.AddControllers();

//registering External API 
builder.Services.AddHttpClient("jsonplaceholder", c =>{
       c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//membuat logging serta exceptionnya
builder.Logging.AddSerilog(new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger());


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    try
    {
        await next();
        if (context.Response.StatusCode == 404)
        {
            Log.Warning("Resource not found: {Path}", context.Request.Path);
            await context.Response.WriteAsync("Permintaan Tidak ditemukan.");
        }
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Unhandled exception caught");
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync("An error occurred. Coba Periksa Codingannmu.");
    }
   
});


app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
