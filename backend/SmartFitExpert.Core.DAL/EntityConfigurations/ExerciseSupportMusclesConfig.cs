using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class ExerciseSupportMusclesConfig : IEntityTypeConfiguration<ExerciseSupportMuscles>
    {
        public void Configure(EntityTypeBuilder<ExerciseSupportMuscles> builder)
        {
            builder.HasOne(x => x.MuscleGroup)
                .WithMany(x => x.ExerciseSupportMuscles)
                .HasForeignKey(x => x.MuscleGroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Exercise)
                .WithMany(x => x.ExerciseSupportMuscles)
                .HasForeignKey(x => x.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
