using BandaTocarDomain.Interfaces;
using BandaTocarDomain.Services;
// using BandaTocaRepository.Data;
// using BandaTocaRepository.Data.Repository;
using BandaTocarDI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Register();
// builder.Services.AddScoped<IBandaTocarService, BandaTocarService>();
// builder.Services.AddScoped<IBandaTocarRepository, BandaTocarRepository>();
// builder.Services.AddDbContext<BandaTocarDbContext>();

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
