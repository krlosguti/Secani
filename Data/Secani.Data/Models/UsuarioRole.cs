using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class UsuarioRole : _BaseEntity
    {
        public long UsuarioId { get; set; }
        public long RoleId { get; set; }
    }

    public class UsuarioRoleConfiguration : IEntityTypeConfiguration<UsuarioRole>
    {
        public void Configure(EntityTypeBuilder<UsuarioRole> builder)
        {

        }
    }
}
