using Jac.Tripulantes.Controllers;
using Jac.Tripulantes.DAL;
using Jac.Tripulantes.Models;
using Newtonsoft.Json;

namespace Jac.Tripulantes.Test
{
    [TestClass]
    public class UnitTestCategoria
    {
        TripulantesController controller = new (new FakeRepositorio());

        [TestMethod]
        public void TestCategoriaOK()
        {
            var response = controller.GetCategoriaAsync(1).Result;

            var responseData = response as Categoria;
            //Assert.AreEqual(1, responseData.Id);


            var CategoriaEncontrada = controller.GetCategoriaAsync(1).Result;
            //Assert.IsNotNull(CategoriaEncontrada);
            //Assert.AreEqual((CategoriaEncontrada as Categoria).Id, 1);
 
        }

        [TestMethod]
        public void TestCategoriaError()
        {
            //var CategoriaEncontrada = controller.GetCategoriaAsync(1).Result;
            //Assert.IsNull(CategoriaEncontrada);
        }

    }
}