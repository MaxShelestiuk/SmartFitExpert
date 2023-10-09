using SmartFitExpert.Core.DAL.Entities;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.Common.DTO.MuscleGroup
{
    public sealed class MuscleGroupWithDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public MuscleGroupSize Size { get; set; }
        public ICollection<Exercise>? Exercises { get; set; }
    }
}
