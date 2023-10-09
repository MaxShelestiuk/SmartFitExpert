using SmartFitExpert.Core.BLL.Interfaces;
using SmartFitExpert.Core.BLL.Services;

namespace SmartFitExpert.Core.WebAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IMuscleGroupService, MuscleGroupService>();
        }
    }
}
