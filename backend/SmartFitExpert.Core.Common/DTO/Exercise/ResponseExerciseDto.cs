using SmartFitExpert.Core.Common.DTO.Equipment;
using SmartFitExpert.Core.Common.DTO.MuscleGroup;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.Common.DTO.Exercise
{
    public sealed class ResponseExerciseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ResponseMuscleGroupDto? TargetMuscleGroup { get; set; } = null!;
        public int Priority { get; set; }
        public JointType Jointness { get; set; }
        public ICollection<ResponseMuscleGroupDto> SupportMuscles { get; set; } = new List<ResponseMuscleGroupDto>();
        public ICollection<ResponseEquipmentDto> Equipments { get; set; } = new List<ResponseEquipmentDto>();
    }
}
