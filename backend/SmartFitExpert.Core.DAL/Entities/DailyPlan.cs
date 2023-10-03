using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public class DailyPlan
    {
        public int Id { get; set; }
        public AgeGroup AgeGroup { get; set; }
        public Goal Goal { get; set; }
        public int TotalDays { get; set; }
        public int DayNumber { get; set; }
        public ExerciseOrgType ExerciseOrganizationType { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}