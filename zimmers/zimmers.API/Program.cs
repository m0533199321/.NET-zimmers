using zimmers.API.Controllers;
using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.data;
using zimmers.data.Repository;
using zimmers.service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<DataContext>();
builder.Services.AddScoped<IService<Cleaner>, CleanerService>();
builder.Services.AddScoped<IService<Order>, OrderService>();
builder.Services.AddScoped<IService<Owner>, OwnerService>();
builder.Services.AddScoped<IService<User>, UserService>();
builder.Services.AddScoped<IService<Zimmer>, ZimmerService>();
builder.Services.AddScoped<IRepository<Cleaner>, CleanRepository>();
builder.Services.AddScoped<IRepository<Order>, OrderRepository>();
builder.Services.AddScoped<IRepository<Owner>, OwnerRepository>();
builder.Services.AddScoped<IRepository<User>, UserRepository>();
builder.Services.AddScoped<IRepository<Zimmer>, ZimmerRepository>();
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
