using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("ApplicantStatus")]
    public class ApplicantStatus : BaseEntity
    {
        public string ApplicantStatusName { get; set; }

        /*----- Relations -----*/

        public ICollection<Applicant>? Applicants { get; set; }

    }
}
