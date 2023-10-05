using SmartFitExpert.Core.DAL.Entities.Abstract;

namespace SmartFitExpert.Core.DAL.Entities.JoinEntities
{
    public sealed class ExerciseDailyPlans: BaseEntity<int>
    {
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int ExerciseId { get; set; }
        public int DailyPlanId { get; set; }
        public Exercise Exercise { get; set; } = null!;
        public DailyPlan DailyPlan { get; set; } = null!;
    }
}