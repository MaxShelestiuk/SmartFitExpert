using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class DailyPlanConfig : IEntityTypeConfiguration<DailyPlan>
    {
        public void Configure(EntityTypeBuilder<DailyPlan> builder)
        {
            builder.Property(x => x.AgeGroup).IsRequired();
            builder.Property(x => x.Goal).IsRequired();
            builder.Property(x => x.TotalDays).IsRequired();
            builder.Property(x => x.DayNumber).IsRequired();
            builder.Property(x => x.ExerciseOrganizationType).IsRequired();
        }
    }
}