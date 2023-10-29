using JobResearchSystem.Domain.Entities.Extend;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("JobSeekers")]
    public class JobSeeker : BaseEntity
    {
       
        public string? CVFilePath { get; set; }
        public string? ImageFilePath { get; set; }

        /*----- Relations -----*/

        public ICollection<Applicant>? Applicants { get; set; }

        //////////

        //public ICollection<Skill>? Skills { get; set; }
        public ICollection<Skill> Skills { get; set; }

        //////////

        public ICollection<Experience>? Experiences { get; set; }

        //////////

        public ICollection<Qualification>? Qualifications { get; set; }

        //////////

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
