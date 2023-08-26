using JNA.Condominio.Domain.Interfaces;
using JNA.Condominio.Domain.Services;
using JNA.Condominio.Infra.Data;
using JNA.Condominio.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace JNA.Condominio.Api.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void ConfigureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("CondominioConnection");

            services.AddDbContext<db_CondominioContext>(options =>
                options.UseSqlServer(connectionString));


            services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IMoradorRepository, MoradorRepository>();
            services.AddScoped<MoradorService>();

            services.AddControllers();
        }
    }
}
