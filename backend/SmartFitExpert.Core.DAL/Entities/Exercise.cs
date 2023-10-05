﻿using SmartFitExpert.Core.DAL.Entities.Abstract;
using SmartFitExpert.Core.DAL.Enums;

namespace SmartFitExpert.Core.DAL.Entities
{
    public sealed class Exercise : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public MuscleGroup TargetMuscleGroup { get; set; } = null!;
        public int Priority { get; set; }
        public JointType Jointness { get; set; }
        public ICollection<MuscleGroup> SupportMuscleGroups { get; set; } = new List<MuscleGroup>();
        public ICollection<Equipment> Equipments { get; set; } = new List<Equipment>();
    }
}