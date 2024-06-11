using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class Usuario : BaseEntity
    {
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Telefonos { get; set; }
        public int EstadoUsuarioId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
