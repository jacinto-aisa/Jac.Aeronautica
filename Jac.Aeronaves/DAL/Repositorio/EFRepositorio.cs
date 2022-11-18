using Jac.Aeronaves.DAL.Contexto;
using Jac.Aeronaves.Models;
using Jac.Tripulantes.DAL.Contexto;

namespace Jac.Aeronaves.DAL.Repositorio
{
    public class EFRepositorio : IAeronavesRepositorio
    {
        private readonly AeronavesContexto contexto;
        public EFRepositorio()
        {
            string[] args = { "" };
            contexto = new AeronavesContextoFactory().CreateDbContext(args);
        }

        public Task<Aeronave?> DameAeronavePorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Aeronave>?> FiltroAeronaves(Func<Aeronave, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
