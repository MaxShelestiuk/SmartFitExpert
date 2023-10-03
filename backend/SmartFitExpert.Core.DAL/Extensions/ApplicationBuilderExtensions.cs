using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SmartFitExpert.Core.DAL.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseSmartFitExpertCoreContext(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            using var context = scope?.ServiceProvider.GetRequiredService<SmartFitExpertCoreContext>();
            context?.Database.Migrate();
        }
    }
}
