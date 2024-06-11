using Secani.Data.Common;

namespace Secani.Data.Models
{
    public class UsuarioRole : BaseEntity
    {
        public long UsuarioId { get; set; }
        public long RoleId { get; set; }
    }
}
