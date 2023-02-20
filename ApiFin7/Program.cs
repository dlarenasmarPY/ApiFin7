using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Core.Interfaces.UseCase.BancoEstado;
using Web.Api.Core.Interfaces.UseCase.ForPay;
using Web.Api.Core.Interfaces.UseCase.LibroMayor;
using Web.Api.Core.Interfaces.UseCase;
using Web.Api.Core.UseCases.Bancoestado;
using Web.Api.Core.UseCases.LibroMayor;
using Web.Api.Core.UseCases;
using Web.Api.Presenters.BancoEstado;
using Web.Api.Infrastructure.Data.EntityFramework.Repositories;
using Web.Api.Infrastructure.Data.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Autofac;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBalanceCuentasPagarCentroCostoUseCase, BalanceCuentasPagarCentroCostoUseCase>();
builder.Services.AddScoped<IBalanceCuentasPorPagarCentroCostoProvisionUseCase, BalanceCuentasPorPagarCentroCostoProvisionUseCase>();
builder.Services.AddScoped<ICuentasPorPagarRepository, CuentasPorPagarRepository>();
builder.Services.AddScoped<IForPayRepository, ForPayRepository>();
builder.Services.AddScoped<IgetClienteForPay, getClienteForPay>();
builder.Services.AddScoped<IBancoEstadoRepository, BancoEstadoRepository>();
builder.Services.AddScoped<IGetPlantillaUseCase, GetPlantillaUseCase>();
builder.Services.AddScoped<IgetLibroMayor, getLibroMayor>();
builder.Services.AddScoped<ILibroMayorRepository, LibroMayorRepository>();
builder.Services.AddTransient<GetPlantillaPresenter>();

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
