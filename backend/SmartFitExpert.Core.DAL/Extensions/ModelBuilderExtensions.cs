using Microsoft.EntityFrameworkCore;
using SmartFitExpert.Core.DAL.EntityConfigurations;

namespace SmartFitExpert.Core.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserProfileConfig).Assembly);
        }
    }
}