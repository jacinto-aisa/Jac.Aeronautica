
using Jac.Embarque.DAL.Repositorio;
using Jac.Embarque.Models;
using Jac.Embarque.Services.Aeronaves;
using Jac.Embarque.Services.Tripulantes;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Jac.Tripulantes.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmbarqueController : ControllerBase
    {
        private readonly IEmbarqueRepositorio _embarqueRepositorio;
        private readonly IServicioAeronave _servicioAeronave;
        private readonly IServicioTripulante _servicioTripulante;

        public EmbarqueController(IEmbarqueRepositorio embarqueRepositorio,
                                  IServicioAeronave servicioAeronave,
                                  IServicioTripulante servicioTripulante)

        {
            _servicioAeronave = servicioAeronave;
            _servicioTripulante = servicioTripulante;
            _embarqueRepositorio = embarqueRepositorio;
        }

        [HttpGet("Aeronave/{Id}")]
        public async Task<EmbarqueAvion?> GetAeronaveAsync(int Id)
        {
            return await _embarqueRepositorio.DameEmbarquePorId(Id);
        }
        [HttpGet("UltimoEmbarquesPorAeronave/{Id}")]
        public async Task<EmbarqueAvion> DameEmbarquePorId(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("EmbarquesPorAeronave/{Id}")]
        public Task<List<EmbarqueAvion>?> DameEmbarquesPorIdDeAvion(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("AeronavesPorTripulante/{Id}")]
        public Task<List<Aeronave>?> DameAeronavePorTripulante(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("AeronavesPorCategoria/{Id}")]
        public Task<List<Aeronave>?> DameAeronavesPorCategoria(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("DameTodosAviones")]
        public async Task<List<Aeronave>?> DameTodosLosAviones()
        {
            return await _servicioAeronave.DameTodos();
        }
    }

}
