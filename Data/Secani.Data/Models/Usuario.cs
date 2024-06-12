using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class Usuario : _BaseEntity
    {
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Telefonos { get; set; }
        public int EstadoUsuarioId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

        }
    }
}
