namespace SmartFitExpert.Core.Common.DTO.Exercise
{
    public sealed class CreateExerciseDto
    {
        public ExerciseDto? ExerciseDto { get; set; }
        public ICollection<int> SupportMuscleGroups { get; set; } = new List<int>();
        public ICollection<int> Equipments { get; set; } = new List<int>();
    }
}
