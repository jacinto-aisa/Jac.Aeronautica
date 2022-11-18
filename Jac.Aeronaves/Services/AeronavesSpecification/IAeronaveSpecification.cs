
using Jac.Aeronaves.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jac.Aeronaves.Services.TripulanteSpecification
{
    public interface IAeronaveSpecification
    {
        bool IsValid(Aeronave Aeronave);
    }
}