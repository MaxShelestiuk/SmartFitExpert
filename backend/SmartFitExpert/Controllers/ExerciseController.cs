using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartFitExpert.Core.BLL.Interfaces;
using SmartFitExpert.Core.BLL.Services;
using SmartFitExpert.Core.Common.DTO.Equipment;
using SmartFitExpert.Core.Common.DTO.Exercise;

namespace SmartFitExpert.Core.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseExerciseDto>> CreateExerciseAsync([FromBody] CreateExerciseDto newExerciseDto)
        {
            return Ok(await _exerciseService.CreateExerciseAsync(newExerciseDto));
        }

        [HttpGet("all")]
        public async Task<ActionResult<ICollection<ResponseExerciseDto>>> GetAllExercisesAsync()
        {
            return Ok(await _exerciseService.GetAllExercisesAsync());
        }

        [HttpGet("{exerciseId}")]
        public async Task<ActionResult<ResponseExerciseDto>> GetExerciseAsync(int exerciseId)
        {
            return Ok(await _exerciseService.GetExerciseAsync(exerciseId));
        }

        [HttpPut("{exerciseId}")]
        public async Task<ActionResult<ResponseExerciseDto>> UpdateMuscleGroupAsync(int exerciseId, [FromBody] CreateExerciseDto newExercise)
        {
            return Ok(await _exerciseService.UpdateExerciseAsync(exerciseId, newExercise));
        }

        [HttpDelete("{exerciseId}")]
        public async Task<IActionResult> DeleteExerciseAsync(int exerciseId)
        {
            await _exerciseService.DeleteExerciseAsync(exerciseId);
            return NoContent();
        }
    }
}
