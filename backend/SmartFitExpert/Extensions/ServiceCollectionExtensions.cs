using SmartFitExpert.Core.BLL.Interfaces;
using SmartFitExpert.Core.BLL.Services;
using System.Text.Json.Serialization;

namespace SmartFitExpert.Core.WebAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            services.AddScoped<IMuscleGroupService, MuscleGroupService>();
            services.AddScoped<IEquipmentService, EquipmentService>();
            services.AddScoped<IExerciseService, ExerciseService>();
        }
    }
}
