using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class Alerta : BaseEntity
    {
        public int SubcategoriaId { get; set; }
        public string Descripcion { get; set; }
        public char Alias { get; set; }
    }
}
