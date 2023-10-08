using SmartFitExpert.Core.DAL.Entities.Abstract;

namespace SmartFitExpert.Core.DAL.Entities.JoinEntities
{
    public sealed class ExerciseEquipments : BaseEntity<int>
    {
        public int ExerciseId { get; set; }
        public int EquipmentId { get; set; }
        public Exercise Exercise { get; set; } = null!;
        public Equipment Equipment { get; set; } = null!;
    }
}
