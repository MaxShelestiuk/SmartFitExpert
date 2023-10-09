using AutoMapper;
using SmartFitExpert.Core.BLL.Interfaces;
using SmartFitExpert.Core.DAL.Entities;
using SmartFitExpert.Core.DAL;
using SmartFitExpert.Core.Common.DTO.Equipment;
using Microsoft.EntityFrameworkCore;

namespace SmartFitExpert.Core.BLL.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly SmartFitExpertCoreContext _context;
        private readonly IMapper _mapper;
        public EquipmentService(SmartFitExpertCoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseEquipmentDto> CreateEquipmentAsync(EquipmentDto newEquipment)
        {
            var createdEquipment = (await _context.Equipment.AddAsync(_mapper.Map<Equipment>(newEquipment))).Entity;
            await _context.SaveChangesAsync();
            return _mapper.Map<ResponseEquipmentDto>(createdEquipment);
        }

        public async Task<ICollection<ResponseEquipmentDto>> GetAllEquipmentsAsync()
        {
            return _mapper.Map<List<ResponseEquipmentDto>>(await _context.Equipment.ToListAsync());
        }

        public async Task<ResponseEquipmentDto> GetEquipmentAsync(int equipmentId)
        {
            var equipment = await _context.Equipment.FirstOrDefaultAsync(eq => eq.Id == equipmentId);
            return _mapper.Map<ResponseEquipmentDto>(equipment);
        }

        public async Task DeleteEquipmentAsync(int equipmentId)
        {
            var equipment = await _context.Equipment.FindAsync(equipmentId);

            ValidateEquipment(equipment);

            _context.Equipment.Remove(equipment!);
            await _context.SaveChangesAsync();
        }

        public async Task<ResponseEquipmentDto> UpdateEquipmentAsync(int equipmentId, EquipmentDto newEquipment)
        {
            var existingEquipment = await _context.Equipment
                .FirstOrDefaultAsync(eq => eq.Id == equipmentId);

            ValidateEquipment(existingEquipment);

            _mapper.Map(newEquipment, existingEquipment);

            await _context.SaveChangesAsync();

            return _mapper.Map<ResponseEquipmentDto>(existingEquipment)!;
        }

        private void ValidateEquipment(Equipment? entity)
        {
            if (entity is null)
            {
                throw new Exception($"Entity '{nameof(Equipment)}' not found");
            }
        }
    }
}
