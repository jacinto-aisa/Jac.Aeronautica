using Jac.Embarque.Models;

namespace Jac.Aeronaves.DAL.Repositorio
{
    public class FakeRepositorio : IAeronavesRepositorio
    {
        readonly List<EmbarqueAvion> Embarques;
        public FakeRepositorio()
        {
            Embarques = new List<EmbarqueAvion>()
            {
                new EmbarqueAvion() { Id = 1,Aeronave=1,NumeroPasajeros=234,TripulantesId="1,4",Fecha = DateTime.Now},
                new EmbarqueAvion() { Id = 2,Aeronave=1,NumeroPasajeros=134,TripulantesId="1,2,3",Fecha = DateTime.Parse("20221001")},
                new EmbarqueAvion() { Id = 3,Aeronave=1,NumeroPasajeros=34,TripulantesId="1,3",Fecha = DateTime.Parse("20211101")},
                new EmbarqueAvion() { Id = 4,Aeronave=2,NumeroPasajeros=23,TripulantesId="2,3",Fecha = DateTime.Parse("20221001")},
                new EmbarqueAvion() { Id = 5,Aeronave=1,NumeroPasajeros=334,TripulantesId="2,3",Fecha = DateTime.Parse("20221001")},
                new EmbarqueAvion() { Id = 6,Aeronave=4,NumeroPasajeros=10,TripulantesId="2,3,4",Fecha = DateTime.Parse("20221001")},
                new EmbarqueAvion() { Id = 7,Aeronave=3,NumeroPasajeros=134,TripulantesId="1,2,3",Fecha = DateTime.Parse("20221001")},
                new EmbarqueAvion() { Id = 8,Aeronave=1,NumeroPasajeros=134,TripulantesId="1",Fecha = DateTime.Parse("20221001")},
                new EmbarqueAvion() { Id = 9,Aeronave=1,NumeroPasajeros=534,TripulantesId="3",Fecha = DateTime.Parse("20221001") }
            };
        }
        public async Task<EmbarqueAvion?> DameEmbarquePorId(int Id)
        {
            return await Task.Run(() => Embarques.Find(x => x.Id == Id));
        }

        public async Task<List<EmbarqueAvion>?> FiltroEmbarques(Func<EmbarqueAvion, bool> predicate)
        {
            return await Task.Run(() => Embarques.AsQueryable().Where(predicate).ToList());
        }
    }
}
