using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    public class JobSeekerSkills
    {

        /*----- Relation -----*/

        [ForeignKey(nameof(JobSeeker))]
        public int? JobSeekerId { get; set; }
        public JobSeeker? JobSeeker { get; set; }

        //////////////

        [ForeignKey(nameof(Skill))]
        public int? SkillId { get; set; }
        public Skill? Skill { get; set; }
    }
}
