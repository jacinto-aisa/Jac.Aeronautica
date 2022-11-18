using Jac.Tripulantes.Controllers;
using Jac.Tripulantes.DAL;
using Jac.Tripulantes.DAL.Repositorio;
using Jac.Tripulantes.Models;

namespace Jac.Tripulantes.Test
{
    [TestClass]
    public class UnitTestTripulante
    {
        TripulantesController controller = new(new FakeRepositorio());
        [TestMethod]
        public void TestTripulanteOK()
        {

        }

        [TestMethod]
        public void TestTripulanteError()
        {

        }
    }
}