using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Qualifications")]
    public class Qualification : BaseEntity
    {
        [Key]
        public int QualificationId { get; set; }
        public string SchoolName { get; set; }
        public string? Degree { get; set; }
        public string? FieldOfStudy { get; set; }
        public double? Duration { get; set; }
        public DateTime? QualificationStartDate { get; set; }
        public DateTime? QualificationEndDate { get; set; }

        public double? Grade { get; set; }
        public string? QualificationDescription { get; set; }

        /*----- Relations -----*/

        [ForeignKey(nameof(JobSeeker))]
        public int? JobSeekerId { get; set; }

        public JobSeeker? JobSeeker { get; set; }

    }
}