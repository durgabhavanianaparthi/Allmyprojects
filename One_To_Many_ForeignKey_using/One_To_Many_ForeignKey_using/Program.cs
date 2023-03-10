using Microsoft.EntityFrameworkCore;
using One_To_Many_ForeignKey_using.Database;
using One_To_Many_ForeignKey_using.DataManager;
using One_To_Many_ForeignKey_using.Model;
using One_To_Many_ForeignKey_using.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StateAndCityContext>(opts => opts.UseSqlServer(builder.Configuration["StateCity"]));
//builder.Services.AddControllers();
builder.Services.AddScoped<IDataRepository<State>, StateDataManager>();
builder.Services.AddScoped<IDataRepository<City>, CityDataManager>();


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
