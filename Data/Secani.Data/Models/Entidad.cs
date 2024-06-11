using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class Entidad : BaseEntity
    {
        public int TipoEntidadId { get; set; }
        public string Nombre { get; set; }
    }
}
