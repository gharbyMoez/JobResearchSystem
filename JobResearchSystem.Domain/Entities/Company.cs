using JobResearchSystem.Domain.Entities.Extend;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Companies")]
    public class Company : BaseEntity
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfJobs { get; set; } //perMonth
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }

        /*----- Relations -----*/

        public ICollection<Job>? Jobs { get; set; }

        ////////////////

        //public ICollection<Experience>? Experience { get; set; }//??

        ////////////////

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

    }
}
