
using Azure.Identity;
using BusinesLogicLayer.DataRepository;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();
//KeyVault
var keyVaultEndpoint = new Uri($"https://{builder.Configuration["DbConnectObject"]}.vault.azure.net/");
builder.Configuration.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());
builder.Services.AddDbContext<StateAndCityDBContext>(x => x.UseSqlServer(builder.Configuration["DurgaSecret"]));
//var keyVaultEndpoint1 = new Uri($"https://{builder.Configuration["DbConnectObject1"]}.vault.azure.net/");
//builder.Configuration.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());

//builder.Services.AddDbContext<StateAndCityDBContext>(x => x.UseSqlServer(builder.Configuration["ClientId"]));
////var keyVaultEndpoint2 = new Uri($"https://{builder.Configuration["DbConnectObject2"]}.vault.azure.net/");
////builder.Configuration.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());

////builder.Services.AddDbContext<StateAndCityDBContext>(x => x.UseSqlServer(builder.Configuration["TenantId"]));


builder.Services.AddScoped<IDataRepository1<City>, CityDataManager>();
builder.Services.AddScoped<IDataRepository2<City>, CityDataManager>();
builder.Services.AddScoped<IDataRepository1<State>, StateDataManager>();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MSAL_Authdemo",
        Version = "v1"
    });
    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.OAuth2,
        Flows = new OpenApiOAuthFlows()
        {
            Implicit = new OpenApiOAuthFlow()
            {
                AuthorizationUrl = new Uri("https://login.microsoftonline.com/8f6bd982-92c3-4de0-985d-0e287c55e379/oauth2/v2.0/authorize"),
                TokenUrl = new Uri("https://login.microsoftonline.com/8f6bd982-92c3-4de0-985d-0e287c55e379/oauth2/v2.0/token"),
                Scopes = new Dictionary<string, string>
                       {
                       {
                       //"api://947949c9-46cf-4e2a-9b92-2b3033d44160/Demo",
                        "api://947949c9-46cf-4e2a-9b92-2b3033d44160/Demo",

                          "Read files"
                       }
                       }
            }
        }
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                 {
                 {
                     new OpenApiSecurityScheme
                     {
                           Reference = new OpenApiReference
                           {
                                  Type = ReferenceType.SecurityScheme,
                                       Id = "oauth2"
                           },
                             Scheme = "oauth2",
                             Name = "oauth2",
                             In = ParameterLocation.Header
                     },
                                  new List < string > ()
                 }});
});



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AuthDemo v1");
        c.OAuthClientId("947949c9-46cf-4e2a-9b92-2b3033d44160");
        c.OAuthClientSecret("~hZ8Q~cGi_ChDvLC1fUSEwXy7FoTQGAp9aYzndal");
        c.OAuthUseBasicAuthenticationWithAccessCodeGrant();
    });
}


app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
 