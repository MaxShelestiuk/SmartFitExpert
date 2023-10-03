using Microsoft.EntityFrameworkCore;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.DAL
{
    public class SmartFitExpertCoreContext: DbContext
    {
        public SmartFitExpertCoreContext(DbContextOptions<SmartFitExpertCoreContext> options) : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles => Set<UserProfile>();
        public DbSet<DailyPlan> DailyPlans => Set<DailyPlan>();
        public DbSet<Exercise> Exercise => Set<Exercise>();
        public DbSet<WeeklyPlan> WeeklyPlans => Set<WeeklyPlan>();
        public DbSet<MuscleGroup> MuscleGroups => Set<MuscleGroup>();
    }
}