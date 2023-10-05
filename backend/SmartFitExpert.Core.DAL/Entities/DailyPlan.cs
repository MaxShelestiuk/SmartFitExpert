﻿using SmartFitExpert.Core.DAL.Entities.Abstract;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public sealed class DailyPlan : BaseEntity<int>
    {
        public AgeGroup AgeGroup { get; set; }
        public Goal Goal { get; set; }
        public int TotalDays { get; set; }
        public int DayNumber { get; set; }
        public ExerciseOrgType ExerciseOrganizationType { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}