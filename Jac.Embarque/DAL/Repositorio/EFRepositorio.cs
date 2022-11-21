
using Jac.Embarque.DAL.Contexto;
using Jac.Embarque.DAL.Repositorio;
using Jac.Embarque.Models;

namespace Jac.Embarque.DAL.Repositorio
{
    public class EFRepositorio : IEmbarqueRepositorio
    {
        private readonly EmbarqueContexto contexto;
        public EFRepositorio()
        {
            string[] args = { "" };
            contexto = new EmbarqueContextoFactory().CreateDbContext(args);
        }

        public Task<Aeronave?> DameAeronavePorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Aeronave>?> DameAeronavePorTripulante(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Aeronave>?> DameAeronavesPorCategoria(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<EmbarqueAvion> DameEmbarquePorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmbarqueAvion>?> DameEmbarquesPorIdDeAvion(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Aeronave>?> FiltroAeronaves(Func<Aeronave, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<Aeronave>?> FiltroAeronaves(Func<EmbarqueAvion, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
