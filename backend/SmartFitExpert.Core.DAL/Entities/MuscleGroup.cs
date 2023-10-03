using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public class MuscleGroup
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public MuscleGroupSize Size { get; set; }
    }
}