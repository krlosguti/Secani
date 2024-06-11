namespace Secani.Data.Common
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
        public long CreatedByUserId { get; set; } = 0;
        public long UpdatedByUserId { get; set; } = 0;
    }
}
