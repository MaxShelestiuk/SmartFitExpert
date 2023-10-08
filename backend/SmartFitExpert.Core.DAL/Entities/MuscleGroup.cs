using SmartFitExpert.Core.DAL.Entities.Abstract;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public sealed class MuscleGroup : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public MuscleGroupSize Size { get; set; }
        public ICollection<ExerciseSupportMuscles> ExerciseSupportMuscles { get; set; } = new List<ExerciseSupportMuscles>();
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}