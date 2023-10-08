using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class ExerciseEquipmentsConfig : IEntityTypeConfiguration<ExerciseEquipments>
    {
        public void Configure(EntityTypeBuilder<ExerciseEquipments> builder)
        {
            builder.HasOne(x => x.Equipment)
                .WithMany(x => x.ExerciseEquipments)
                .HasForeignKey(x => x.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Exercise)
                .WithMany(x => x.ExerciseEquipments)
                .HasForeignKey(x => x.ExerciseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
