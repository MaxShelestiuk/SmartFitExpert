using SmartFitExpert.Core.Common.DTO.Equipment;

namespace SmartFitExpert.Core.BLL.Interfaces
{
    public interface IEquipmentService
    {
        Task<ResponseEquipmentDto> CreateEquipmentAsync(EquipmentDto newEquipment);
        Task<ICollection<ResponseEquipmentDto>> GetAllEquipmentsAsync();
        Task<ResponseEquipmentDto> GetEquipmentAsync(int equipmentId);
        Task DeleteEquipmentAsync(int equipmentId);
        Task<ResponseEquipmentDto> UpdateEquipmentAsync(int equipmentId, EquipmentDto newEquipment);
    }
}
