using AutoMapper;
using SmartFitExpert.Core.Common.DTO.Exercise;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.BLL.MappingProfiles
{
    public sealed class ExerciseProfile : Profile
    {
        public ExerciseProfile() 
        {
            CreateMap<Exercise, ExerciseDto>().ReverseMap();
            CreateMap<Exercise, ResponseExerciseDto>()
                .ForMember(dto => dto.SupportMuscles, opt => opt.MapFrom(ex => ex.ExerciseSupportMuscles.Select(exsm => exsm.MuscleGroup)))
                .ForMember(dto => dto.Equipments, opt => opt.MapFrom(ex => ex.ExerciseEquipments.Select(exeq => exeq.Equipment)));
        }
    }
}
