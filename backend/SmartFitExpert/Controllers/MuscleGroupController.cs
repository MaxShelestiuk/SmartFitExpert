using Microsoft.AspNetCore.Mvc;
using SmartFitExpert.Core.BLL.Interfaces;
using SmartFitExpert.Core.Common.DTO.MuscleGroup;

namespace SmartFitExpert.Core.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuscleGroupController : ControllerBase
    {
        private readonly IMuscleGroupService _muscleGroupService;
        public MuscleGroupController(IMuscleGroupService muscleGroupService)
        {
            _muscleGroupService = muscleGroupService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<ICollection<ResponseMuscleGroupDto>>> GetAllMuscleGroupsAsync()
        {
            return Ok(await _muscleGroupService.GetAllMuscleGroupsAsync());
        }

        [HttpGet("{muscleGroupId}")]
        public async Task<ActionResult<MuscleGroupWithDetailsDto>> GetMuscleGroupAsync(int projectId)
        {
            return Ok(await _muscleGroupService.GetMuscleGroupAsync(projectId));
        }

        [HttpPost]
        public async Task<ActionResult<MuscleGroupDto>> CreateMuscleGroupAsync([FromBody] MuscleGroupDto newMuscleGroup)
        {
            return Ok(await _muscleGroupService.CreateMuscleGroupAsync(newMuscleGroup));
        }

        [HttpPut("{muscleGroupId}")]
        public async Task<ActionResult<ResponseMuscleGroupDto>> UpdateMuscleGroupAsync(int muscleGroupId, [FromBody] MuscleGroupDto newMuscleGroup)
        {
            return Ok(await _muscleGroupService.UpdateMuscleGroupAsync(muscleGroupId, newMuscleGroup));
        }

        [HttpDelete("{muscleGroupId}")]
        public async Task<IActionResult> DeleteMuscleGroupAsync(int muscleGroupId)
        {
            await _muscleGroupService.DeleteMuscleGroupAsync(muscleGroupId);
            return NoContent();
        }
    }
}
