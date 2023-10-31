using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    public class Applicant : BaseEntity
    {

        /*----- Relations -----*/

        public int JobId { get; set; }

        public Job Job { get; set; }

        //////////

        public int JobSeekerId { get; set; }

        public JobSeeker JobSeeker { get; set; }

        //////////

        public int ApplicantStatusId { get; set; }

        public ApplicantStatus ApplicantStatus { get; set; }
    }
}
