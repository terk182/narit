
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

using System.Configuration;


using narit_mis_api.Models;
using narit_acc_api.Models;
using App.Resolver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAccServices();
builder.Services.AddCustomServices();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
builder.Services.AddMvc();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NARIT_MIS_LINKContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnectton")));

builder.Services.AddDbContext<CGI_ACCContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnectton_acc")));

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
