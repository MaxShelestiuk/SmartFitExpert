using SmartFitExpert.Core.DAL.Entities.Abstract;

namespace SmartFitExpert.Core.DAL.Entities.JoinEntities
{
    public sealed class WeekDailyPlans: BaseEntity<int>
    {
        public int WeekPlanId { get; set; }
        public int DailyPlanId { get; set; }
        public WeeklyPlan WeeklyPlan { get; set; } = null!;
        public DailyPlan DailyPlan { get; set; } = null!;
    }
}