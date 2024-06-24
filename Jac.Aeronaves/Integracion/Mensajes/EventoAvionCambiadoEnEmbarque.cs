

namespace Jac.Aeronaves.Integracion.Mensajes
{
    public class EventoAvionCambiadoEnEmbarque : IEventoIntegracion
    {
        public int Id { get; set; }
        public int AvionOriginal { get; set; }
        public int AvionFinal { get; set; }
    }
}
