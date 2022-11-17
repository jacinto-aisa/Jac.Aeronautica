using Jac.Tripulantes.Models;

namespace Jac.Tripulantes.DAL
{
    public class FakeRepositorio : ITripulantesRepositorio
    {
        readonly List<Categoria> Categorias;
        readonly List<Tripulante> Tripulantes;

        public FakeRepositorio()
        {
            Categorias = new()
            {
                new Categoria() { Id = 1, Descripcion = "Categoria normal", BonificacionAnual = 67f },
                new Categoria() { Id = 2, Descripcion = "Categoria premium", BonificacionAnual = 76f }
            };


            Tripulantes = new List<Tripulante>(){
                new Tripulante(){ Id = 1, Nombre ="Manolo", CategoriaId = 1, Experiencia = 6 },
                new Tripulante(){ Id = 2, Nombre ="Eustaquio", CategoriaId = 1, Experiencia =8 },
                new Tripulante(){ Id = 3, Nombre ="Ana", CategoriaId = 2, Experiencia =9 },
                new Tripulante(){ Id = 4, Nombre="Juana",CategoriaId = 2, Experiencia=10}
            };
        }
        public async Task<Categoria?> DameCategoriaPorId(int Id)
        {
            return await Task.Run(() => Categorias.FirstOrDefault(x => x.Id == Id));
        }


        public async Task<TripulanteConCategoria> DameTripulanteConCategoria(int Id)
        {
            var tripulante = await DameTripulantePorId(Id);
            var categoria = await DameCategoriaPorId(tripulante.CategoriaId);
            return new TripulanteConCategoria()
            {
                Tripulante = tripulante,
                Categoria = categoria
            };
        }

        public async Task<Tripulante?> DameTripulantePorId(int Id)
        {
            return await Task.Run(() => Tripulantes.Find(x => x.Id == Id));
        }
    }
}
