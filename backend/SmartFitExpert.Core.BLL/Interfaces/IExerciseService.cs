using SmartFitExpert.Core.Common.DTO.Exercise;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.BLL.Interfaces
{
    public interface IExerciseService
    {
        Task<ResponseExerciseDto> CreateExerciseAsync(CreateExerciseDto newExerciseDto);
        Task<ICollection<ResponseExerciseDto>> GetAllExercisesAsync();
        Task<ResponseExerciseDto> GetExerciseAsync(int exerciseId);
        Task<ResponseExerciseDto> UpdateExerciseAsync(int exerciseId, CreateExerciseDto newExercise);
        Task DeleteExerciseAsync(int exerciseId);
    }
}
