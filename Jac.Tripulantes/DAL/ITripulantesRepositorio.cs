using Jac.Tripulantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jac.Tripulantes.DAL
{
    public interface ITripulantesRepositorio
    {
        Tripulante DameTripulantePorId(int Id);
        Categoria DameCategoriaPorId(int Id);
        TripulanteConCategoria DameTripulanteConCategoria(int Id);
    }
}