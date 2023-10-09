using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartFitExpert.Core.BLL.Interfaces;
using SmartFitExpert.Core.Common.DTO.MuscleGroup;
using SmartFitExpert.Core.DAL;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.BLL.Services
{
    public sealed class MuscleGroupService : IMuscleGroupService
    {
        private readonly SmartFitExpertCoreContext _context;
        private readonly IMapper _mapper;
        public MuscleGroupService(SmartFitExpertCoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<MuscleGroupDto> CreateMuscleGroupAsync(MuscleGroupDto newMuscleGroup)
        {
            var createdMuscleGroup = (await _context.MuscleGroups.AddAsync(_mapper.Map<MuscleGroup>(newMuscleGroup))).Entity;
            await _context.SaveChangesAsync();
            return _mapper.Map<MuscleGroupDto>(createdMuscleGroup);
        }

        public async Task<ICollection<ResponseMuscleGroupDto>> GetAllMuscleGroupsAsync()
        {
            return _mapper.Map<List<ResponseMuscleGroupDto>>(await _context.MuscleGroups.ToListAsync());
        }

        public async Task<MuscleGroupWithDetailsDto> GetMuscleGroupAsync(int muscleGroupId)
        {
            var muscleGroup = await _context.MuscleGroups.Include(mg => mg.Exercises).FirstOrDefaultAsync(mg => mg.Id == muscleGroupId);
            return _mapper.Map<MuscleGroupWithDetailsDto>(muscleGroup);
        }

        public async Task DeleteMuscleGroupAsync(int muscleGroupId)
        {
            var muscleGroup = await _context.MuscleGroups.FindAsync(muscleGroupId);

            ValidateMuscleGroup(muscleGroup);

            _context.MuscleGroups.Remove(muscleGroup!);
            await _context.SaveChangesAsync();
        }

        public async Task<ResponseMuscleGroupDto> UpdateMuscleGroupAsync(int muscleGroupId, MuscleGroupDto newMuscleGroup)
        {
            var existingMG = await _context.MuscleGroups
                .FirstOrDefaultAsync(mg => mg.Id == muscleGroupId);

            ValidateMuscleGroup(existingMG);

            _mapper.Map(newMuscleGroup, existingMG);

            await _context.SaveChangesAsync();

            return _mapper.Map<ResponseMuscleGroupDto>(existingMG)!;
        }

        private void ValidateMuscleGroup(MuscleGroup? entity)
        {
            if (entity is null)
            {
                throw new Exception($"Entity '{nameof(MuscleGroup)}' not found");
            }
        }
    }
}
