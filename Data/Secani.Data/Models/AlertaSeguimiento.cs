using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class AlertaSeguimiento : BaseEntity
    {
        public long AlertaId { get; set; }
        public long SeguimientoId { get; set; }
        public string Observaciones { get; set; }
        public int EstadoId { get; set; }
        public DateTime UltimaFechaSeguimiento { get; set; }
    }
}
