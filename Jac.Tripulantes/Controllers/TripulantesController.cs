using Jac.Tripulantes.DAL.Repositorio;
using Jac.Tripulantes.Models;
using Jac.Tripulantes.Services.TripulanteSpecification;
using Microsoft.AspNetCore.Mvc;

namespace Jac.Tripulantes.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TripulantesController : ControllerBase
    {
        private readonly ITripulantesRepositorio _tripulantesRepositorio;
        private readonly ITripulanteSpecification _tripulanteSpecification;
        public TripulantesController(ITripulantesRepositorio tripulantesRepositorio,
                                     ITripulanteSpecification tripulanteSpecification)
        {
            _tripulanteSpecification= tripulanteSpecification;
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
        //[HttpGet("ListaValidos")]
        //public async Task<List<Tripulante>> ListaValidos()
        //{
        //    return await _tripulantesRepositorio.FiltroTripulantes().AsQueryable;
        //}
    }

}
