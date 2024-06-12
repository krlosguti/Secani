using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class Ausencia : _BaseEntity
    {
        public long UsuarioId { get; set; }
        public DateTime FechaAusencia { get; set; }
        public int DiasAusencia { set; get; }
        public string MotivoAusencia { get; set; }
    }

    public class AusenciaConfiguration : IEntityTypeConfiguration<Ausencia>
    {
        public void Configure(EntityTypeBuilder<Ausencia> builder)
        {
            builder.Property(a => a.FechaAusencia).IsRequired();
            builder.Property(a => a.DiasAusencia).IsRequired().HasAnnotation("MinValue", 0);
            builder.Property(a => a.MotivoAusencia).IsRequired().HasMaxLength(155).HasAnnotation("MinLength", 10);
        }
    }
}
