using SmartFitExpert.Core.DAL.Entities.Abstract;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;

namespace SmartFitExpert.Core.DAL.Entities
{
    public sealed class Equipment : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<ExerciseEquipments> ExerciseEquipments { get; set; } = new List<ExerciseEquipments>();
    }
}
