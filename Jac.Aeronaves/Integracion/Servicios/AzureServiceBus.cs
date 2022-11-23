using Azure.Messaging.ServiceBus;
using Jac.Aeronaves.Integracion.Mensajes;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Jac.Aeronaves.Integracion.Servicios
{
    public class AzureServiceBus : IServicioDeIntegracion
    {
        readonly string cadenaConexion = string.Empty;
        readonly string ColaAvion = string.Empty;

        public AzureServiceBus(IConfiguration configuracion)
        {
            if (configuracion is not null)
            {
                cadenaConexion = configuracion["ConnectionStrings:ServicioAzureServiceBus"] ?? "";
                ColaAvion = configuracion["ConnectionStrings:NombreColaAviones"] ?? "";
            }
        }
        public async Task RecibeEventoAvionModificado(EventoAvionCambiadoEnEmbarque cambio)
        {
            var client = new ServiceBusClient(cadenaConexion);
            var processor = client.CreateProcessor(ColaAvion, new ServiceBusProcessorOptions());
            processor.ProcessMessageAsync += ManejadorDeMensaje;
            processor.ProcessErrorAsync += ErrorHandler;

            // start processing 
            await processor.StartProcessingAsync();

            // stop processing 
            //await processor.StopProcessingAsync();

        }
        static async Task ManejadorDeMensaje(ProcessMessageEventArgs args)
        {
            string body = args.Message.Body.ToString();
            var evento = JsonSerializer.Deserialize<EventoAvionCambiadoEnEmbarque>(body);
            Console.WriteLine($"Received: {body}");
            // complete the message. messages is deleted from the queue. 
            await args.CompleteMessageAsync(args.Message);
        }

        // handle any errors when receiving messages
        static async Task ErrorHandler(ProcessErrorEventArgs args)
        {
            await Task.Run(()=>Console.WriteLine(args.Exception.ToString()));
        }
    }
}
