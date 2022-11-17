using Jac.Tripulantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jac.Tripulantes.DAL
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

        public Task<Tripulante> DameTripulantePorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}