using AutoMapper;
using SmartFitExpert.Core.Common.DTO.Equipment;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.BLL.MappingProfiles
{
    public sealed class EquipmentProfile : Profile
    {
        public EquipmentProfile() 
        {
            CreateMap<EquipmentDto, Equipment>().ReverseMap();
            CreateMap<ResponseEquipmentDto, Equipment>().ReverseMap();
        }
    }
}
