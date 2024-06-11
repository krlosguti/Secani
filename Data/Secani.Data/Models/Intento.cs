using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class Intento : BaseEntity
    {
        public long ContactoNNAId { get; set; }
        public string Email { get; set; }
        public DateTime FechaIntento { get; set; }
        public string Telefono { get; set; }
        public int TipoResultadoIntentoId { get; set; }
        public int TipoFallaIntentoId { get; set; }
    }
}
