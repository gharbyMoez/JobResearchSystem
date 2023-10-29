using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Experiances")]
    public class Experience : BaseEntity
    {
        public string ExperianceCompanyName { get; set; }

        public string ExperianceTitle { get; set; }

        public DateTime? ExperianceStartDate { get; set; }
        public DateTime? ExperianceEndDate { get; set; }

        public string? PositionDescription { get; set; }

        /*----- Relations -----*/

        [ForeignKey(nameof(JobSeeker))]
        public int JobSeekerId { get; set; }

        public JobSeeker JobSeeker { get; set; }


    }
}
