using Microsoft.EntityFrameworkCore;
using UnitTesting_Using_WebApi.Data;
using UnitTesting_Using_WebApi.Model;
using UnitTesting_Using_WebApi.Repository;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbContextClass>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("UnitTesting")));
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddControllers();




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
