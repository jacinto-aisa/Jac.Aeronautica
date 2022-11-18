using Jac.Aeronaves.Models;

namespace Jac.Aeronaves.DAL.Repositorio
{
    public class FakeRepositorio : IAeronavesRepositorio
    {
        readonly List<Aeronave> Aeronaves;
        public FakeRepositorio()
        {
            Aeronaves = new List<Aeronave>()
            {
                new Aeronave() { Id = 1,Matricula = "uisdjxx",NumeroMotores=1,IncrementoSueldo=0.7f,MesesDesdeMantenimento=7 },
                new Aeronave() { Id = 2,Matricula = "udsisdjxx", NumeroMotores = 2, IncrementoSueldo = 0.1f, MesesDesdeMantenimento = 5 },
                new Aeronave() { Id = 3,Matricula = "uidddsdjxx", NumeroMotores = 3, IncrementoSueldo = 0.14f, MesesDesdeMantenimento = 4 },
                new Aeronave() { Id = 4,Matricula = "uzzzisdjxx", NumeroMotores = 2, IncrementoSueldo = 0.07f, MesesDesdeMantenimento = 72 }
            };
        }
        public async Task<Aeronave?> DameAeronavePorId(int Id)
        {
            return await Task.Run(() => Aeronaves.Find(x => x.Id == Id));
        }

        public async Task<List<Aeronave>?> FiltroAeronaves(Func<Aeronave, bool> predicate)
        {
            return await Task.Run(() => Aeronaves.AsQueryable().Where(predicate).ToList());
        }
    }
}
