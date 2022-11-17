using Jac.Tripulantes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jac.Tripulantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripulantesController : ControllerBase
    {
        [HttpGet("Tripulante/{Id}")]
        public async Task<IActionResult> GetTripulanteAsync(int Id)
        {
            return Ok(new Tripulante());
        }
        [HttpGet("Categoria/{Id}")]
        public async Task<IActionResult> GetCategoriaAsync(int Id)
        {
            return Ok(new Categoria());
        }
        [HttpGet("TripulanteConCategoria/{Id}")]
        public async Task<IActionResult> GetTripulanteConCategoria(int Id)
        {
            return Ok(new TripulanteConCategoria());
        }
    }

}
