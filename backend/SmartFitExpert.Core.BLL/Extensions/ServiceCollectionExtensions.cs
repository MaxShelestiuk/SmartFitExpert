using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SmartFitExpert.Core.BLL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}