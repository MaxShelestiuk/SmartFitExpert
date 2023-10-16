using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.Common.DTO.Exercise
{
    public sealed class ExerciseDto
    {
        public string Name { get; set; } = string.Empty;
        public int? TargetMuscleGroupId { get; set; }
        public int Priority { get; set; }
        public JointType Jointness { get; set; }
    }
}
