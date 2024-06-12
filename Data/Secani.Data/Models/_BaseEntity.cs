using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class _BaseEntity
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
        public long CreatedByUserId { get; set; } = 0;
        public long UpdatedByUserId { get; set; } = 0;
    }

    public class BaseEntityConfiguration : IEntityTypeConfiguration<_BaseEntity>
    {
        public void Configure(EntityTypeBuilder<_BaseEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.DateUpdated).IsRequired(false);
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.UpdatedByUserId).IsRequired(false);
        }
    }
}
