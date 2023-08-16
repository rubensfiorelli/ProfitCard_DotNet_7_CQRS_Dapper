using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProfitCard.CrossCutting.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services
            //    .AddRepositories();

            //services
            //    .AddDbContext<ApplicationDbContext>(opts => opts
            //        .UseMySql(configuration.GetConnectionString("DbConnection"),
            //         ServerVersion.AutoDetect(configuration.GetConnectionString("DbConnection")),
            //         b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));


            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            //services.AddScoped(typeof(IEventRepository), typeof(EventoRepository));
            //services.AddScoped(typeof(IEventService), typeof(EventService));


            return services;
        }
    }
}
