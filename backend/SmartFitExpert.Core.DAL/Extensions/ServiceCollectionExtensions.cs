using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SmartFitExpert.Core.DAL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSmartFitExpertCoreContext(this IServiceCollection services, IConfiguration configuration)
        {
            var smartFitCoreDbConnectionString = "SmartFitExpertCoreDBConnection";
            var connectionsString = configuration.GetConnectionString(smartFitCoreDbConnectionString);
            services.AddDbContext<SmartFitExpertCoreContext>(options =>
                options.UseSqlServer(
                    connectionsString,
                    opt => opt.MigrationsAssembly(typeof(SmartFitExpertCoreContext).Assembly.GetName().Name)));
        }
    }
}