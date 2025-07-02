using Microsoft.EntityFrameworkCore;
using OscBackend.Repository;
using OscBackend.Repository.Interfaces;
using OscBackend.Services;
using OscBackend.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Postgres");

builder.Services.AddDbContext<RepositoryContext>(
opts => opts.UseNpgsql(connectionString));


builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IOngLocationService, OngLocationService>();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontend");

app.UseAuthorization();

app.MapControllers();

app.Run();
