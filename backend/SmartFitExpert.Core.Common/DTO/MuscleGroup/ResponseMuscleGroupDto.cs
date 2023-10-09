using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.Common.DTO.MuscleGroup
{
    public sealed class ResponseMuscleGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public MuscleGroupSize Size { get; set; }
    }
}
