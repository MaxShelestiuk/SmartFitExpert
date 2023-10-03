using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public class WeeklyPlan
    {
        public int Id { get; set; }
        public int TotalDays { get; set; }
        public string TrainingRestBalance { get; set; } = string.Empty;
        public WeekPlanType WeekPlanType { get; set; }
        public ICollection<DailyPlan> DailyPlans { get; set; } = new List<DailyPlan>();
    }
}