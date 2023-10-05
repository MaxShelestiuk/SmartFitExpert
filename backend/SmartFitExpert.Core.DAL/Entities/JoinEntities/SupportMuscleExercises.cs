using SmartFitExpert.Core.DAL.Entities.Abstract;

namespace SmartFitExpert.Core.DAL.Entities.JoinEntities
{
    public sealed class SupportMuscleExercises : BaseEntity<int>
    {
        public int MuscleGroupId { get; set; }
        public int ExerciseId { get; set; }
        public MuscleGroup MuscleGroup { get; set; } = null!;
        public Exercise Exercise { get; set; } = null!;
    }
}