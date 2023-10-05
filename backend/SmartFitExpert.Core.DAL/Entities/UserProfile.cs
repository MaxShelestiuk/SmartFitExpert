using SmartFitExpert.Core.DAL.Entities.Abstract;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public sealed class UserProfile : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public Goal Goal { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public int AvailableDays { get; set; }
        public string Restrictions { get; set; } = string.Empty;
    }
}