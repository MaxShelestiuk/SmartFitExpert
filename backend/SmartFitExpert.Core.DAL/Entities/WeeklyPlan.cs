using SmartFitExpert.Core.DAL.Entities.Abstract;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public sealed class WeeklyPlan: BaseEntity<int>
    {
        public int TotalDays { get; set; }
        public string TrainingRestBalance { get; set; } = string.Empty;
        public WeekPlanType WeekPlanType { get; set; }
        public ICollection<DailyPlan> DailyPlans { get; set; } = new List<DailyPlan>();
    }
}