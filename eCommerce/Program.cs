using eCommerce.Data;
using eCommerce.Repositories.Implementations;
using eCommerce.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var Configuration = builder.Configuration.GetConnectionString("connection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration));

builder.Services.AddScoped<ICouponRepo, CouponRepo>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();

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
