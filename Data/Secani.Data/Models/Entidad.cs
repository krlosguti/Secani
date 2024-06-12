using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class Entidad : _BaseEntity
    {
        public int TipoEntidadId { get; set; }
        public string Nombre { get; set; }
    }

    public class EntidadConfiguration : IEntityTypeConfiguration<Entidad>
    {
        public void Configure(EntityTypeBuilder<Entidad> builder)
        {

        }
    }
}
