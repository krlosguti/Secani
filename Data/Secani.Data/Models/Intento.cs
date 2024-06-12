﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class Intento : _BaseEntity
    {
        public long ContactoNNAId { get; set; }
        public string Email { get; set; }
        public DateTime FechaIntento { get; set; }
        public string Telefono { get; set; }
        public int TipoResultadoIntentoId { get; set; }
        public int TipoFallaIntentoId { get; set; }
    }

    public class IntentoConfiguration : IEntityTypeConfiguration<Intento>
    {
        public void Configure(EntityTypeBuilder<Intento> builder)
        {

        }
    }
}
