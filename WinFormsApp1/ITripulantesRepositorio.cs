using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public interface ITripulantesRepositorio
    {
        Tripulante DameTripulantePorId(int Id);
        Categoria DameCategoriaPorId(int Id);
        TripulanteConCategoria DameTripulanteConCategoria(int Id);
    }
}