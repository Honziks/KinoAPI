using KinoAPI.Repositories;
using KinoAPI.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddScoped<IMovieRepository, InMemoryAuthorRepository>();
builder.Services.AddScoped<MovieServices>();

builder.Services.AddSingleton<IMovieRepository, InMemoryAuthorRepository>();
builder.Services.AddScoped<MovieServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
