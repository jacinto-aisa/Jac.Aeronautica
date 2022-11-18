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
        public async Task TestTripulanteOK()
        {
            var tripulanteEncontrado = await controller.GetTripulanteAsync(1);
            Assert.IsNotNull(tripulanteEncontrado);
            Assert.AreEqual(1, tripulanteEncontrado.Id);
            Assert.AreEqual("Manolo", tripulanteEncontrado.Nombre);
        }

        [TestMethod]
        public async Task TestTripulanteError()
        {
            var tripulanteEncontrado = await controller.GetTripulanteAsync(100);
            Assert.IsNull(tripulanteEncontrado);
        }
    }
}