using App.ExampleTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Narit_API.Models;
using System.Configuration;
using App.Resolver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var r = new DependencyResolver();
builder.Services.AddCustomServices();
builder.Services.AddControllers();
//builder.Services.AddCors(c =>
//{
//    c.AddPolicy("AllowOrigin", Options => Options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

//});

builder.Services.AddMvc();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NARIT_MIS_LINKContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnectton")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
        c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "Web API");
    });
}
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials()); // allow credentials

app.UseAuthorization();

app.MapControllers();

app.Run();
