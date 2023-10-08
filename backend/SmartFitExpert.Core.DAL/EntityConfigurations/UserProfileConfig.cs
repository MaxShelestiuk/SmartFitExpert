using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.DAL.EntityConfigurations
{
    public sealed class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.Property(x => x.AvailableDays).IsRequired();
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Goal).IsRequired();
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x => x.Weight).IsRequired();

            builder.HasOne(x => x.WeeklyPlan)
                .WithMany(x => x.UserProfiles)
                .HasForeignKey(x => x.WeeklyPlanId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
