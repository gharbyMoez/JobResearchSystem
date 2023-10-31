namespace JobResearchSystem.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public string SkillName { get; set; }

        /*----- Relations -----*/

        public ICollection<JobSeeker> JobSeekers { get; set; } = new List<JobSeeker>();
    }
}
