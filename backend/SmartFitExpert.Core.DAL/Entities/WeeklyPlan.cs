using SmartFitExpert.Core.DAL.Entities.Abstract;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public sealed class WeeklyPlan: BaseEntity<int>
    {
        public int TotalDays { get; set; }
        public string TrainingRestBalance { get; set; } = string.Empty;
        public WeekPlanType WeekPlanType { get; set; }
        public ICollection<WeekDailyPlans> WeekDailyPlans { get; set; } = new List<WeekDailyPlans>();
        public ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
    }
}