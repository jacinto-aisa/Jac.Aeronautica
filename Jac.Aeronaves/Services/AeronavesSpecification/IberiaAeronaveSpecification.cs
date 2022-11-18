using Jac.Aeronaves.Models;
using Jac.Aeronaves.Services.TripulanteSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jac.Tripulantes.Services.TripulanteSpecification
{
    public class IberiaAeronaveSpecification : IAeronaveSpecification
    {
        public bool IsValid(Aeronave aeronave)
        {
            return aeronave.MesesDesdeMantenimento < 6;
        }
    }
}