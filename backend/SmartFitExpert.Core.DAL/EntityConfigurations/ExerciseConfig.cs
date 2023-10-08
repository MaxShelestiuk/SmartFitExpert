using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class ExerciseConfig : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Priority).IsRequired();
            builder.Property(x => x.Jointness).IsRequired();

            builder.HasOne(x => x.TargetMuscleGroup)
                .WithMany(x => x.Exercises)
                .HasForeignKey(x => x.TargetMuscleGroupId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
