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
        public void TestTripulanteOK()
        {
            //var TripulanteEncontrada = controller.GetTripulanteAsync(1);
            //Assert.IsNotNull(TripulanteEncontrada);
            //var Resultado = TripulanteEncontrada.Result as Tripulante;
            //Assert.AreEqual(Resultado.Id, 1);

        }

        [TestMethod]
        public void TestTripulanteError()
        {
            //var CategoriaEncontrada = controller.GetCategoriaAsync(100);
            //Assert.IsNull(CategoriaEncontrada);
        }
    }
}