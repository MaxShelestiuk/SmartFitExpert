using SmartFitExpert.Core.DAL.Extensions;
using SmartFitExpert.Core.BLL.Extensions;
using SmartFitExpert.Core.WebAPI.Extensions;

namespace SmartFitExpert
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSmartFitExpertCoreContext(builder.Configuration);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.RegisterCustomServices();
            builder.Services.AddAutoMapper();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseSmartFitExpertCoreContext();
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}