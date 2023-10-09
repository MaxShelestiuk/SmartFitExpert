using Microsoft.AspNetCore.Mvc;
using SmartFitExpert.Core.BLL.Interfaces;
using SmartFitExpert.Core.Common.DTO.Equipment;

namespace SmartFitExpert.Core.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<ICollection<ResponseEquipmentDto>>> GetAllEquipmentsAsync()
        {
            return Ok(await _equipmentService.GetAllEquipmentsAsync());
        }

        [HttpGet("{equipmentId}")]
        public async Task<ActionResult<ResponseEquipmentDto>> GetEquipmentAsync(int equipmentId)
        {
            return Ok(await _equipmentService.GetEquipmentAsync(equipmentId));
        }

        [HttpPost]
        public async Task<ActionResult<ResponseEquipmentDto>> CreateEquipmentAsync([FromBody] EquipmentDto newEquipment)
        {
            return Ok(await _equipmentService.CreateEquipmentAsync(newEquipment));
        }

        [HttpPut("{equipmentId}")]
        public async Task<ActionResult<ResponseEquipmentDto>> UpdateMuscleGroupAsync(int equipmentId, [FromBody] EquipmentDto newEquipment)
        {
            return Ok(await _equipmentService.UpdateEquipmentAsync(equipmentId, newEquipment));
        }

        [HttpDelete("{equipmentId}")]
        public async Task<IActionResult> DeleteEquipmentAsync(int equipmentId)
        {
            await _equipmentService.DeleteEquipmentAsync(equipmentId);
            return NoContent();
        }
    }
}
