using Jac.Tripulantes.DAL.Contexto;
using Jac.Tripulantes.Models;
using Jac.Tripulantes.Services.TripulanteSpecification;

namespace Jac.Tripulantes.DAL.Repositorio
{
    public class EFRepositorio : ITripulantesRepositorio
    {
        private readonly TripulanteContexto? contexto;
        public EFRepositorio()
        {
            string[] args = { "" };
            contexto = new TripulanteContextoFactory().CreateDbContext(args);
        }
        public async Task<Categoria?> DameCategoriaPorId(int Id)
        {
            return await contexto.Categorias.FindAsync(Id);
        }

        public async Task<TripulanteConCategoria?> DameTripulanteConCategoria(int Id)
        {
            var tripulanteEncontrado = await DameTripulantePorId(Id);
            var categoriaEncontrada = await DameCategoriaPorId(Id);
            if (tripulanteEncontrado != null &&
                categoriaEncontrada != null)
            {
                return new TripulanteConCategoria()
                {
                    Tripulante = tripulanteEncontrado,
                    Categoria = categoriaEncontrada
                };
            }
            else
            {
                return null;
            }
        }

        public async Task<Tripulante?> DameTripulantePorId(int Id)
        {
            return await contexto.Tripulantes.FindAsync(Id);
        }

    }

    



}
