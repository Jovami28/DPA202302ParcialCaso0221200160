using DPA202302ParcialCaso0221200160.Data;
using DPA202302ParcialCaso0221200160.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPA202302ParcialCaso0221200160.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryController : ControllerBase
    {
        [HttpPost("Agregar")]

        public async Task<IActionResult> Create(Territory territory)
        {
            var result = await _Territory isnt
            if (!result)
                return BadRequest(result);

            return Ok(result);
        }

    }
}
