using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Data;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Mapping;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DevConnection");
builder.Services.AddDbContext<DentalCenterContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddTransient<IPacienteRepository, PacienteRepository>();
builder.Services.AddTransient<ITratamientoRepository, TratamientoRepository>();
builder.Services.AddTransient<ICabMedicoRepository, CabMedicoRepository>();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutomapperProfile());
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
