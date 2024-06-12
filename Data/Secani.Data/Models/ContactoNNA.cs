using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class ContactoNNA : _BaseEntity
    {
        public long NNAId { get; set; }
        public string Nombres { get; set; }
        public int ParentescoId { get; set; }
        public string Email { get; set; }
        public string Telefonos { get; set; }
        public string TelefnosInactivos { get; set; }
    }

    public class ContactoNNAConfiguration : IEntityTypeConfiguration<ContactoNNA>
    {
        public void Configure(EntityTypeBuilder<ContactoNNA> builder)
        {

        }
    }
}
