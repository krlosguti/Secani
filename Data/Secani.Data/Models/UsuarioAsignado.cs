﻿using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class UsuarioAsignado : BaseEntity
    {
        public long UsuarioId { get; set; }
        public long SeguimientoId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string Observaciones { get; set; }
    }
}
