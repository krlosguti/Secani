using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class Role : BaseEntity
    {
        public string NombreRole { get; set; }
        public string Descripcion { get; set; }
    }
}
