using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("ApplicantStatus")]
    public class ApplicantStatus : BaseEntity
    {
        [Key]
        public int ApplicantStatusId { get; set; }
        public string ApplicantStatusName { get; set; }

        /*----- Relations -----*/

        public ICollection<Applicant>? Applicants { get; set; }

    }
}
