﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class Alerta : _BaseEntity
    {
        public int SubcategoriaId { get; set; }
        public string Descripcion { get; set; }
        public char Alias { get; set; }
    }

    public class AlertaConfiguration : IEntityTypeConfiguration<Alerta>
    {
        public void Configure(EntityTypeBuilder<Alerta> builder)
        {
            builder.Property(a => a.Descripcion).HasMaxLength(255);
            builder.Property(a =>a.Alias).IsRequired();
        }
    }
}
