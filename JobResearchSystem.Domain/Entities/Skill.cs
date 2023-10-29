using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Skills")]
    public class Skill : BaseEntity
    {
        
        public string SkillName { get; set; }

        /*----- Relations -----*/

        public ICollection<JobSeeker> JobSeekers { get; set; }

        //[ForeignKey(nameof(JobSeeker))]
        //public int? JobSeekerId { get; set; }

        //public JobSeeker? JobSeeker { get; set; }
    }
}
