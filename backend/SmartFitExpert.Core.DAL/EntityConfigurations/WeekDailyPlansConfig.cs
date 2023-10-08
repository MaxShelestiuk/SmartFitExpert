using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class WeekDailyPlansConfig : IEntityTypeConfiguration<WeekDailyPlans>
    {
        public void Configure(EntityTypeBuilder<WeekDailyPlans> builder)
        {
            builder.HasOne(x => x.DailyPlan)
                .WithMany(x => x.WeekDailyPlans)
                .HasForeignKey(x => x.DailyPlanId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.WeeklyPlan)
                .WithMany(x => x.WeekDailyPlans)
                .HasForeignKey(x => x.WeekPlanId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
