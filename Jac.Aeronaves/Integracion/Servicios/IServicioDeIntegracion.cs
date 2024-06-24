using Jac.Aeronaves.Integracion.Mensajes;

namespace Jac.Aeronaves.Integracion.Servicios
{
    public interface IServicioDeIntegracion
    {
        public Task RecibeEventoAvionModificado(EventoAvionCambiadoEnEmbarque cambio);
    }
}
