namespace JobResearchSystem.Domain.Entities
{
    public class BaseEntity
    {

        // common attributes
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DateDeleted { get; set; }
        public DateTime? DateUpdated { get; set; }

    }
}


