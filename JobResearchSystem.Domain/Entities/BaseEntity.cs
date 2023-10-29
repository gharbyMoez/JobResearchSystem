using System.ComponentModel.DataAnnotations;

namespace JobResearchSystem.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        // common attributes
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DateDeleted { get; set; }
        public DateTime? DateUpdated { get; set; }

    }
}


