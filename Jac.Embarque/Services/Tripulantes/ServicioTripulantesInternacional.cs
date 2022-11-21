using Jac.Embarque.Models;

namespace Jac.Embarque.Services.Tripulantes
{
    public class ServicioTripulantesInternacional : IServicioTripulante
    {
        private readonly HttpClient _httpClient;

        public ServicioTripulantesInternacional(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Categoria?> GetCategoriaAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Tripulante?> GetTripulanteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<TripulanteConCategoria?> GetTripulanteConCategoria(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tripulante>?> ListaTripulantesValidos()
        {
            throw new NotImplementedException();
        }
    }
}
