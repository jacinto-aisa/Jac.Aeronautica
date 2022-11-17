using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public interface ITripulanteSpecification
    {
        bool IsValid(Tripulante Tripulante);
    }
}