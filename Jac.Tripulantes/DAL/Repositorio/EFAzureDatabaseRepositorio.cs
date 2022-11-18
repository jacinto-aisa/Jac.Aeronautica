using Jac.Tripulantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Jac.Tripulantes.DAL.Repositorio
{
    public class EFAzureDatabaseRepositorio : ITripulantesRepositorio
    {
        public Task<Categoria?> DameCategoriaPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<TripulanteConCategoria?> DameTripulanteConCategoria(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Tripulante?> DameTripulantePorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Categoria>?> FiltroCategorias(Expression<Func<Categoria, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tripulante>?> FiltroTripulantes(Expression<Func<Tripulante, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}