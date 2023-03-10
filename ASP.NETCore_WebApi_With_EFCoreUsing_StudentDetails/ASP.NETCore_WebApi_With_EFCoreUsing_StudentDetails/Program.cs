using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Data;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Datamanager;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentContext>(opts => opts.UseSqlServer(builder.Configuration["StudentDB"]));
builder.Services.AddControllers();
builder.Services.AddScoped<IDataRepository<Student>, StudentManager>();
builder.Services.AddScoped<IDataRepository<StudentPerformance>, StudentPerformanceManager>();


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
