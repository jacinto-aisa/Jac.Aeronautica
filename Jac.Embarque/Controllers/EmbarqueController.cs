
using Jac.Aeronaves.DAL.Repositorio;
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
        private readonly IEmbarqueRepositorio _aeronavesRepositorio;

        public EmbarqueController(IEmbarqueRepositorio aeronaveRepositorio)

        {
            _aeronavesRepositorio = aeronaveRepositorio;
        }

        [HttpGet("Aeronave/{Id}")]
        public async Task<EmbarqueAvion?> GetAeronaveAsync(int Id)
        {
            return await _aeronavesRepositorio.DameEmbarquePorId(Id);
        }
       

    }

}
