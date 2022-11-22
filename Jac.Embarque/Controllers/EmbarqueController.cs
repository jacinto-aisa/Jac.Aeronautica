using Jac.Embarque.DAL.Repositorio;
using Jac.Embarque.Models;
using Jac.Embarque.Services.Aeronaves;
using Jac.Embarque.Services.Tripulantes;
using Microsoft.AspNetCore.Mvc;

namespace Jac.Embarque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmbarqueController : ControllerBase
    {
        private readonly IServicioAeronave? _servicioAeronave;
        private readonly IServicioTripulante _servicioTripulante;
        private readonly IEmbarqueRepositorio _embarqueRepositorio;


        public EmbarqueController(
            IEmbarqueRepositorio embarqueRepositorio,
            IServicioAeronave servicioAeronave,
            IServicioTripulante servicioTripulante)
        {
            this._embarqueRepositorio = embarqueRepositorio;
            this._servicioAeronave = servicioAeronave;
            this._servicioTripulante = servicioTripulante;
        }
        [HttpGet("Embarque/{Id}")]
        public async Task<EmbarqueAvion?> GetEmbarqueAsync(int Id)
        {
            return await _embarqueRepositorio.DameEmbarquePorId(Id);
        }
        [HttpGet("UltimoEmbarquesPorAeronave/{Id}")]
        public async Task<EmbarqueAvion> DameEmbarquePorId(int Id)
        {
            return await _embarqueRepositorio.DameEmbarquesPorIdDeAvion(Id);
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
            if (_servicioAeronave is not null)
                return await _servicioAeronave.DameTodos();
            else
                return null;
        }
    }

}
