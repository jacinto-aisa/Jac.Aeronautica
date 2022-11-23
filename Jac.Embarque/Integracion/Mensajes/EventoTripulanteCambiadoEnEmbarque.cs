namespace Jac.Embarque.Integracion.Mensajes
{
    public class EventoTripulanteCambiadoEnEmbarque
    {
        public int Id { get; set; }
        public String ListaOriginal { get; set; } = String.Empty;
        public String ListaFinal { get; set; } = String.Empty;
    }
}
