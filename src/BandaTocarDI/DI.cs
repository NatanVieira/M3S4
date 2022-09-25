using BandaTocarDomain.Interfaces;
using BandaTocarDomain.Services;
using BandaTocaRepository.Data;
using BandaTocaRepository.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BandaTocarDI{
    public static class DI
    {

        public static IServiceCollection Register(this IServiceCollection services){
            services.AddScoped<IBandaTocarService, BandaTocarService>();
            services.AddScoped<IBandaTocarRepository, BandaTocarRepository>();
            services.AddDbContext<BandaTocarDbContext>();
            return services;
        }

    }
}