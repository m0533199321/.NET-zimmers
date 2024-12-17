using Microsoft.EntityFrameworkCore;
using zimmers.API.Controllers;
using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.data;
using zimmers.data.Repository;
using zimmers.service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(
    options => { options.UseSqlServer("Data Source = DESKTOP-SSNMLFD; Initial Catalog = DBZimmers; Integrated Security = true; "); });
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddScoped<ICleanerService, CleanerService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOwnerService, OwnerService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IZimmerService, ZimmerService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
