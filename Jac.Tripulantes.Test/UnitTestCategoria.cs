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
        public async Task TestCategoriaOK()
        {
            var response = await controller.GetCategoriaAsync(1);
            Assert.IsNotNull(response);
            Assert.AreEqual(1, response.Id);
        }

        [TestMethod]
        public async Task TestCategoriaError()
        {
            var response = await controller.GetCategoriaAsync(100);
            Assert.IsNull(response);
        }

    }
}