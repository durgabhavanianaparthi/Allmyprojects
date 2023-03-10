using Many_to_Many_ForeignKeyUsing.Database;
using Many_to_Many_ForeignKeyUsing.Datamanager;
using Many_to_Many_ForeignKeyUsing.Model;
using Many_to_Many_ForeignKeyUsing.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<API_DBContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("CustomerProduct")));
builder.Services.AddDbContext<API_DBContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("CustomerProduct"))); ;
builder.Services.AddScoped<IDataRepository<Customer>, CustomerDataManager>();
builder.Services.AddScoped<IDataRepository<Product>, ProductDataManager>();
builder.Services.AddScoped<IDataRepository<CustomerProduct>, CustomerProductDataManager>();
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
