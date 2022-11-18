using Jac.Aeronaves.DAL.Repositorio;
using Jac.Aeronaves.Services.TripulanteSpecification;
using Jac.Tripulantes.Services.TripulanteSpecification;

namespace Jac.Aeronaves
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddScoped<IAeronaveSpecification, IberiaAeronaveSpecification>();
            builder.Services.AddScoped<IAeronavesRepositorio, FakeRepositorio>();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}