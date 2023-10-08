using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class MuscleGroupConfig : IEntityTypeConfiguration<MuscleGroup>
    {
        public void Configure(EntityTypeBuilder<MuscleGroup> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Size).IsRequired();
        }
    }
}
