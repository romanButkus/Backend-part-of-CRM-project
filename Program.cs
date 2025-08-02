using backend.Data.Context;
using backend.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionStrings = builder.Configuration.GetConnectionString("Default");

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionStrings));

builder.Services.AddScoped<OutletRepository>();
builder.Services.AddScoped<EmployeeRepository>();
builder.Services.AddScoped<ProductRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
