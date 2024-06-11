using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class ContactoEntidad : BaseEntity
    {
        public long EntidadId { get; set; }
        public string Nombres { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Telefonos { get; set; }
    }
}
