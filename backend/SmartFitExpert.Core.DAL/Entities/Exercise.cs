using SmartFitExpert.Core.DAL.Entities.Abstract;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public sealed class Exercise : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public int? TargetMuscleGroupId { get; set; }
        public MuscleGroup? TargetMuscleGroup { get; set; } = null!;
        public int Priority { get; set; }
        public JointType Jointness { get; set; }
        public ICollection<ExerciseDailyPlans> ExerciseDailyPlans { get; set; } = new List<ExerciseDailyPlans>();
        public ICollection<ExerciseSupportMuscles> ExerciseSupportMuscles { get; set; } = new List<ExerciseSupportMuscles>();
        public ICollection<ExerciseEquipments> ExerciseEquipments { get; set; } = new List<ExerciseEquipments>();
    }
}