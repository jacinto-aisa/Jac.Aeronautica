using Jac.Aeronaves.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Jac.Aeronaves.DAL.Repositorio
{
    public interface IAeronavesRepositorio
    {
        Task<Aeronave?> DameAeronavePorId(int Id);
        Task<List<Aeronave>?> FiltroAeronaves(Func<Aeronave, bool> predicate);
     }
}