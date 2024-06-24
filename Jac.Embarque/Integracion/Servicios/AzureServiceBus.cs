using Azure.Messaging.ServiceBus;
using Jac.Embarque.Integracion.Mensajes;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Jac.Embarque.Integracion.Servicios
{
    public class AzureServiceBus : IServicioDeIntegracion
    {
        readonly string cadenaConexion = string.Empty;
        readonly string ColaAvion = string.Empty;
        readonly string ColaTripulante = string.Empty;

        public AzureServiceBus(IConfiguration configuracion)
        {
            if (configuracion is not null)
            {
                cadenaConexion = configuracion["ConnectionStrings:ServicioAzureServiceBus"] ?? "";
                ColaAvion = configuracion["ConnectionStrings:NombreColaAviones"] ?? "";
                ColaTripulante = configuracion["ConnectionStrings:NombreColaTripulantes"] ?? "";
            }
        }
        public async Task<bool> EnviaEventoAvionModificado(EventoAvionCambiadoEnEmbarque cambio)
        {
            var client = new ServiceBusClient(cadenaConexion);
            var sender = client.CreateSender(ColaAvion);
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
            string jsonString = JsonSerializer.Serialize(cambio);
            var exito = messageBatch.TryAddMessage(new ServiceBusMessage(jsonString));
            await sender.SendMessagesAsync(messageBatch);
            await sender.DisposeAsync();
            await client.DisposeAsync();
            return exito;
        }
        public async Task<bool> EnviaEventoTripulanteModificado(EventoTripulanteCambiadoEnEmbarque cambio)
        {
            var client = new ServiceBusClient(cadenaConexion);
            var sender = client.CreateSender(ColaTripulante);
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
            string jsonString = JsonSerializer.Serialize(cambio);
            var exito  = messageBatch.TryAddMessage(new ServiceBusMessage(jsonString));
            await sender.SendMessagesAsync(messageBatch);
            await sender.DisposeAsync();
            await client.DisposeAsync();
            return exito;
        }
    }
}
