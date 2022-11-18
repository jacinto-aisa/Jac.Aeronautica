using Jac.Tripulantes.DAL.Repositorio;
using Jac.Tripulantes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jac.Tripulantes.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TripulantesController : ControllerBase
    {
        private readonly ITripulantesRepositorio _tripulantesRepositorio;

        public TripulantesController(ITripulantesRepositorio tripulantesRepositorio)
        {
            _tripulantesRepositorio = tripulantesRepositorio;
        }

        [HttpGet("Tripulante/{Id}")]
        public async Task<Tripulante?> GetTripulanteAsync(int Id)
        {
            return await _tripulantesRepositorio.DameTripulantePorId(Id);
        }
        [HttpGet("Categoria/{Id}")]
        public async Task<Categoria?> GetCategoriaAsync(int Id)
        {
            return await _tripulantesRepositorio.DameCategoriaPorId(Id);
        }
        [HttpGet("TripulanteConCategoria/{Id}")]
        public async Task<TripulanteConCategoria?> GetTripulanteConCategoria(int Id)
        {
            return await _tripulantesRepositorio.DameTripulanteConCategoria(Id);
        }
    }

}
