
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

using System.Configuration;


using narit_mis_api.Models;
using narit_mis_api.AccModels;
using App.Resolver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAccServices();
builder.Services.AddCustomServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NARIT_MIS_LINKContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnectton")));

builder.Services.AddDbContext<NARIT_MIS_ACCContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnectton_acc")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials()); // allow credentials

app.UseAuthorization();

app.MapControllers();

app.Run();
