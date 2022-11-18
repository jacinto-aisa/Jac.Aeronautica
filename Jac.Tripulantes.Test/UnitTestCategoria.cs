using Jac.Tripulantes.Controllers;
using Jac.Tripulantes.DAL;
using Jac.Tripulantes.DAL.Repositorio;
using Jac.Tripulantes.Models;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace Jac.Tripulantes.Test
{
    [TestClass]
    public class UnitTestCategoria
    {
        TripulantesController controller = new (new FakeRepositorio());

        [TestMethod]
        public async Task  TestCategoriaOK()
        {
            var CategoriaEncontrada = await controller.GetCategoriaAsync(1);
            Assert.IsNotNull(CategoriaEncontrada);
            Assert.AreEqual(1,CategoriaEncontrada.Id);
            Assert.AreEqual("Categoria normal", CategoriaEncontrada.Descripcion);
         }

        [TestMethod]
        public async Task TestCategoriaError()
        {
            var CategoriaEncontrada = await controller.GetCategoriaAsync(100);
            Assert.IsNull(CategoriaEncontrada);
        }

    }
}