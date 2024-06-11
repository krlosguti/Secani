namespace Secani.Data.Models
{
    public class Notificacion
    {
        public long AlertaSeguimientoId { get; set; }
        public DateTime FechaNotificacion { get; set; }
        public DateTime FechaRespuesta { get; set; }
        public string RespuestaEntidad { get; set; }
        public long EntidadId { get; set; }
    }
}
