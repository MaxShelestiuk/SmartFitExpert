using AutoMapper;
using SmartFitExpert.Core.Common.DTO.MuscleGroup;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.BLL.MappingProfiles
{
    public sealed class MuscleGroupProfile : Profile
    {
        public MuscleGroupProfile() 
        {
            CreateMap<MuscleGroupDto, MuscleGroup>().ReverseMap();
            CreateMap<MuscleGroupWithDetailsDto, MuscleGroup>().ReverseMap();
            CreateMap<ResponseMuscleGroupDto, MuscleGroup>().ReverseMap();
        }
    }
}
