using Jac.Aeronaves.DAL.Repositorio;
using Jac.Tripulantes.Controllers;
using Jac.Tripulantes.Services.TripulanteSpecification;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace Jac.Tripulantes.Test
{
    [TestClass]
    public class UnitTestAeronave
    {
        readonly AeronavesController controller = new (new FakeRepositorio() , new IberiaAeronaveSpecification());

        [TestMethod]
        public async Task TestAeronaveOK()
        {
            var AeronaveEncontrada = await controller.GetAeronaveAsync(1);
            Assert.IsNotNull(AeronaveEncontrada);
            Assert.AreEqual(1, AeronaveEncontrada.Id);
            Assert.AreEqual("uisdjxx", AeronaveEncontrada.Matricula);
         }

        [TestMethod]
        public async Task TestAeronaveError()
        {
            var AeronaveEncontrada = await controller.GetAeronaveAsync(100);
            Assert.IsNull(AeronaveEncontrada);
        }

    }
}