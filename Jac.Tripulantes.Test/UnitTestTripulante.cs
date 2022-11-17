using Jac.Tripulantes.Controllers;
using Jac.Tripulantes.DAL;
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
            var TripulanteEncontrada = await controller.GetTripulanteAsync(1);
            Assert.IsNotNull(TripulanteEncontrada);
            Assert.AreEqual(TripulanteEncontrada.Id, 1);    
            Assert.AreEqual(TripulanteEncontrada.Experiencia, 6);
        }

        [TestMethod]
        public async Task TestTripulanteError()
        {
            var CategoriaEncontrada = await controller.GetCategoriaAsync(100);
            Assert.IsNull(CategoriaEncontrada);
        }
    }
}