using GiaPhaOnline.Domain.Interfaces;
using GiaPhaOnline.Infrastructure;
using GiaPhaOnline.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddDbContext<GiaPhaOnlineDbContext>(options =>
{
    options.UseSqlServer(config.GetConnectionString("GiaPhaOnline"));
});

// Add DI
services.AddScoped<IFamilyRepository, FamilyRepository>();

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