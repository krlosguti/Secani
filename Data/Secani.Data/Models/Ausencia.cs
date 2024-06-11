using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class Ausencia : BaseEntity
    {
        public long UsuarioId { get; set; }
        public DateTime FechaAusencia { get; set; }
        public int DiasAusencia { set; get; }
        public string MotivoAusencia { get; set; }
    }
}
