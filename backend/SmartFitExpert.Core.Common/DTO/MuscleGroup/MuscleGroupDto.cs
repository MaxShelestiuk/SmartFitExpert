using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.Common.DTO.MuscleGroup
{
    public sealed class MuscleGroupDto
    {
        public string Name { get; set; } = string.Empty;
        public MuscleGroupSize Size { get; set; }
    }
}
