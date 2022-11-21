using Jac.Embarque;
using Jac.Embarque.DAL.Repositorio;
using Jac.Embarque.Services.Aeronaves;
using Jac.Embarque.Services.Tripulantes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IEmbarqueRepositorio, FakeRepositorio>();
builder.Services.AddHttpClient<IServicioAeronave, ServicioAeronave_01>(
    cliente =>
    {
        cliente.BaseAddress = new Uri(builder.Configuration["ServicioTripulantes"]);

    })
    .SetHandlerLifetime(TimeSpan.FromMinutes(5));
    //.AddPolicyHandler(ConfiguracionHttpClient.GetRetryPolicy());
    ;
builder.Services.AddHttpClient<IServicioTripulante, ServicioTripulantesInternacional>(
    cliente =>
    {
        cliente.BaseAddress = new Uri(builder.Configuration["ServicioAeronaves"]);
    }
    );
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
