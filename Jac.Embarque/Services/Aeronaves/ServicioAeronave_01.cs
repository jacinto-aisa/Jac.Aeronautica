using Jac.Embarque.Models;

namespace Jac.Embarque.Services.Aeronaves
{
    public class ServicioAeronave_01 : IServicioAeronave
    {
        public Task<Aeronave?> GetAeronaveAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Aeronave>?> ListaAeronavesValidos()
        {
            throw new NotImplementedException();
        }
    }
}
