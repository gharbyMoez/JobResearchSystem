using JobResearchSystem.Domain.Entities.Extend;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("JobSeekers")]
    public class JobSeeker : BaseEntity
    {
        //public string Experience { get; set; }
        // public ICollection<string>? Skills { get; set; }
        //public string Qualification { get; set; }
        public string? CVFilePath { get; set; }
        public string? ImageFilePath { get; set; }

        /*----- Relations -----*/

        public ICollection<Applicant>? Applicants { get; set; }

        //////////

        public ICollection<Skill>? Skills { get; set; }

        //////////

        public ICollection<Experience>? Experiences { get; set; }

        //////////

        public ICollection<Qualification>? Qualifications { get; set; }

        //////////  

        public ICollection<JobSeekerSkill> JobSeekerSkills { get; set; }

        //////////

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
