using JobResearchSystem.Domain.Entities.Extend;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JobResearchSystem.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public int NumberOfJobs { get; set; } //perMonth
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }

        /*----- Relations -----*/

        //[JsonIgnore]
        public virtual ICollection<Job>? Jobs { get; set; } = new List<Job>();

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

    }
}
