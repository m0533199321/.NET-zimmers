using Microsoft.Extensions.DependencyInjection.Extensions;
using zimmers;
using zimmers.Servicies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<UserServicies>();
builder.Services.AddScoped<IDataContext, JSONUsers>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
