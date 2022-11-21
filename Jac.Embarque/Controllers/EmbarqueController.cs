
using Jac.Embarque.DAL.Repositorio;
using Jac.Embarque.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Jac.Tripulantes.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmbarqueController : ControllerBase
    {
        private readonly IEmbarqueRepositorio _embarqueRepositorio;

        public EmbarqueController(IEmbarqueRepositorio embarqueRepositorio)

        {
            _embarqueRepositorio = embarqueRepositorio;
        }

        [HttpGet("Aeronave/{Id}")]
        public async Task<EmbarqueAvion?> GetAeronaveAsync(int Id)
        {
            return await _embarqueRepositorio.DameEmbarquePorId(Id);
        }

        public async Task<EmbarqueAvion> DameEmbarquePorId(int Id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Aeronave>?> FiltroAeronaves(Func<EmbarqueAvion, bool> predicate)
        {
            throw new NotImplementedException();
        }
        Task<List<EmbarqueAvion>?> DameEmbarquesPorIdDeAvion(int Id)
        {
            throw new NotImplementedException();
        }
        Task<List<Aeronave>?> DameAeronavePorTripulante(int Id)
        {
            throw new NotImplementedException();
        }
        Task<List<Aeronave>?> DameAeronavesPorCategoria(int Id)
        {
            throw new NotImplementedException();
        }

    }

}
