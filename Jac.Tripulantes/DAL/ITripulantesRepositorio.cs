using Jac.Tripulantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jac.Tripulantes.DAL
{
    public interface ITripulantesRepositorio
    {
        Task<Tripulante?> DameTripulantePorId(int Id);
        Task<Categoria?> DameCategoriaPorId(int Id);
       Task<TripulanteConCategoria> DameTripulanteConCategoria(int Id);
    }
}