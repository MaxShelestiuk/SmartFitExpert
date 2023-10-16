using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartFitExpert.Core.BLL.Interfaces;
using SmartFitExpert.Core.Common.DTO.Exercise;
using SmartFitExpert.Core.DAL;
using SmartFitExpert.Core.DAL.Entities;
using SmartFitExpert.Core.DAL.Entities.JoinEntities;

namespace SmartFitExpert.Core.BLL.Services
{
    public sealed class ExerciseService : IExerciseService
    {
        private readonly SmartFitExpertCoreContext _context;
        private readonly IMapper _mapper;

        public ExerciseService(SmartFitExpertCoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ResponseExerciseDto> CreateExerciseAsync(CreateExerciseDto newExerciseDto)
        {
            ValidateEntity(newExerciseDto.ExerciseDto);
            var createdExercise = (await _context.Exercise.AddAsync(_mapper.Map<Exercise>(newExerciseDto.ExerciseDto))).Entity;
            if (newExerciseDto.SupportMuscleGroups.Any())
            {
                foreach (var mgId in newExerciseDto.SupportMuscleGroups)
                {
                    createdExercise.ExerciseSupportMuscles.Add(
                        new ExerciseSupportMuscles
                        {
                            MuscleGroupId = mgId
                        });
                }
            }
            if (newExerciseDto.Equipments.Any())
            {
                foreach (var eqId in newExerciseDto.Equipments)
                {
                    createdExercise.ExerciseEquipments.Add(
                        new ExerciseEquipments
                        {
                            EquipmentId = eqId
                        });
                }
            }
            await _context.SaveChangesAsync();
            return _mapper.Map<ResponseExerciseDto>(await GetByIdWithDetailsAsync(createdExercise.Id));
        }

        public async Task<ICollection<ResponseExerciseDto>> GetAllExercisesAsync()
        {
            return _mapper.Map<List<ResponseExerciseDto>>(await _context.Exercise
                .Include(ex => ex.ExerciseEquipments).ThenInclude(exeq => exeq.Equipment)
                .Include(ex => ex.TargetMuscleGroup)
                .Include(ex => ex.ExerciseSupportMuscles).ThenInclude(exsm => exsm.MuscleGroup)
                .ToListAsync());
        }

        public async Task<ResponseExerciseDto> GetExerciseAsync(int exerciseId)
        {
            return _mapper.Map<ResponseExerciseDto>(await GetByIdWithDetailsAsync(exerciseId));
        }

        public async Task DeleteExerciseAsync(int exerciseId)
        {
            var exercise = await _context.Exercise.FindAsync(exerciseId);

            ValidateEntity(exercise);

            _context.Exercise.Remove(exercise!);
            await _context.SaveChangesAsync();
        }

        public async Task<ResponseExerciseDto> UpdateExerciseAsync(int exerciseId, CreateExerciseDto newExercise)
        {
            var existingExercise = await GetByIdWithDetailsAsync(exerciseId);

            _mapper.Map(newExercise.ExerciseDto, existingExercise);

            await _context.SaveChangesAsync();

            return _mapper.Map<ResponseExerciseDto>(existingExercise)!;
        }

        private async Task<Exercise> GetByIdWithDetailsAsync(int id)
        {
            var exercise = await _context.Exercise.Include(ex => ex.ExerciseEquipments).ThenInclude(exeq => exeq.Equipment)
                .Include(ex => ex.TargetMuscleGroup)
                .Include(ex => ex.ExerciseSupportMuscles).ThenInclude(exsm => exsm.MuscleGroup)
                .FirstOrDefaultAsync(ex => ex.Id == id);
            ValidateEntity(exercise);
            return exercise!;
        }
        private void ValidateEntity<T>(T? entity)
        {
            if (entity is null)
            {
                throw new Exception($"Entity '{nameof(T)}' not found");
            }
        }
    }
}
