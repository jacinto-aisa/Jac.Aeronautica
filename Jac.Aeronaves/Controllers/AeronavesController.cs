
using Jac.Aeronaves.DAL.Repositorio;
using Jac.Aeronaves.Models;
using Jac.Aeronaves.Services.TripulanteSpecification;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Jac.Tripulantes.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AeronavesController : ControllerBase
    {
        private readonly IAeronavesRepositorio _aeronavesRepositorio;
        private readonly IAeronaveSpecification _aeronaveSpecification;

        public AeronavesController(IAeronavesRepositorio aeronaveRepositorio,
            IAeronaveSpecification aeronaveSpecification)

        {
            _aeronaveSpecification= aeronaveSpecification;
            _aeronavesRepositorio = aeronaveRepositorio;
        }

        [HttpGet("Aeronave/{Id}")]
        public async Task<Aeronave?> GetAeronaveAsync(int Id)
        {
            return await _aeronavesRepositorio.DameAeronavePorId(Id);
        }
       
        [HttpGet("ListaValidos")]
        public async Task<List<Aeronave>?> ListaAeronavesValidos()
        {
            var Criterio = _aeronaveSpecification.IsValid;
            return await _aeronavesRepositorio.FiltroAeronaves(Criterio);
        }
    }

}
