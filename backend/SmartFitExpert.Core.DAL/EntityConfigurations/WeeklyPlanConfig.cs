using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class WeeklyPlanConfig : IEntityTypeConfiguration<WeeklyPlan>
    {
        public void Configure(EntityTypeBuilder<WeeklyPlan> builder)
        {
            builder.Property(x => x.TotalDays).IsRequired();
            builder.Property(x => x.WeekPlanType).IsRequired();
            builder.Property(x => x.TrainingRestBalance).IsRequired();
        }
    }
}
