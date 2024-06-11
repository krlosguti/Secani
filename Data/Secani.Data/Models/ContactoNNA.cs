﻿using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class ContactoNNA : BaseEntity
    {
        public long NNAId { get; set; }
        public string Nombres { get; set; }
        public int ParentescoId { get; set; }
        public string Email { get; set; }
        public string Telefonos { get; set; }
        public string TelefnosInactivos { get; set; }
    }
}
