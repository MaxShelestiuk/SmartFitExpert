using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class ExerciseDailyPlansConfig : IEntityTypeConfiguration<ExerciseDailyPlans>
    {
        public void Configure(EntityTypeBuilder<ExerciseDailyPlans> builder)
        {
            builder.HasOne(x => x.DailyPlan)
                .WithMany(x => x.ExerciseDailyPlans)
                .HasForeignKey(x => x.DailyPlanId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Exercise)
                .WithMany(x => x.ExerciseDailyPlans)
                .HasForeignKey(x => x.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
