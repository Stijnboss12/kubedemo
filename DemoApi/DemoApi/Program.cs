var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularClient",
      builder =>
      {
          builder
          .AllowAnyOrigin()
          .AllowAnyHeader()
          .AllowAnyMethod();
      });
});

var app = builder.Build();

app.UseCors("AllowAngularClient");

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
