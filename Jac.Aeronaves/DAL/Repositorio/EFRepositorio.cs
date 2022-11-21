using Jac.Aeronaves.DAL.Contexto;
using Jac.Aeronaves.Models;
using Jac.Tripulantes.DAL.Contexto;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Aeronave?> DameAeronavePorId(int Id)
        {
            if (contexto is not null && contexto.Aeronaves is not null)
                return await contexto.Aeronaves.FindAsync(Id);
            return null;
        }

        public async Task<List<Aeronave>?> DameTodos()
        {
            if (contexto is not null && contexto.Aeronaves is not null)
                return await contexto.Aeronaves.ToListAsync();
            return null;
        }

        public Task<List<Aeronave>?> FiltroAeronaves(Func<Aeronave, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
