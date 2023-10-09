using SmartFitExpert.Core.Common.DTO.MuscleGroup;
using SmartFitExpert.Core.DAL.Entities;

namespace SmartFitExpert.Core.BLL.Interfaces
{
    public interface IMuscleGroupService
    {
        Task<MuscleGroupDto> CreateMuscleGroupAsync(MuscleGroupDto newMuscleGroup);
        Task<ICollection<ResponseMuscleGroupDto>> GetAllMuscleGroupsAsync();
        Task<MuscleGroupWithDetailsDto> GetMuscleGroupAsync(int muscleGroupId);
        Task DeleteMuscleGroupAsync(int muscleGroupId);
        Task<ResponseMuscleGroupDto> UpdateMuscleGroupAsync(int muscleGroupId, MuscleGroupDto newMuscleGroup);
    }
}
