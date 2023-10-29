using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Applicants")]
    public class Applicant : BaseEntity
    {

        /*----- Relations -----*/

        [ForeignKey(nameof(Job))]
        public int JobId { get; set; }

        public Job Job { get; set; }

        //////////

        [ForeignKey(nameof(JobSeeker))]
        public int JobSeekerId { get; set; }

        public JobSeeker JobSeeker { get; set; }

        //////////

        [ForeignKey(nameof(ApplicantStatus))]
        public int ApplicantStatusId { get; set; }

        public ApplicantStatus ApplicantStatus { get; set; }
    }
}
