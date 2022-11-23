using Jac.Embarque.Integracion.Mensajes;

namespace Jac.Embarque.Integracion
{
    public interface IServicioDeIntegracion
    {
        public Task<bool> EnviaEventoAvionModificado(EventoAvionCambiadoEnEmbarque cambio);
        public Task<bool> EnviaEventoTripulanteModificado(EventoTripulanteCambiadoEnEmbarque cambio);
    }
}
