using Jac.Embarque.Models;
using Newtonsoft.Json;

namespace Jac.Embarque.Services.Aeronaves
{
    public class ServicioAeronave_01 : IServicioAeronave
    {
        private readonly HttpClient _httpClient;
        public ServicioAeronave_01(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Aeronave>?> DameTodos()
        {
            var coleccion = await _httpClient.GetStringAsync("DameTodos");
            return await Task.Run(() => JsonConvert.DeserializeObject<List<Aeronave>>(coleccion));
        }

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
