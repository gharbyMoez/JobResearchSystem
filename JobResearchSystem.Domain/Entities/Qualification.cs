using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Qualifications")]
    public class Qualification : BaseEntity
    {
        public string SchoolName { get; set; }
        public string? Degree { get; set; }
        public string? FieldOfStudy { get; set; }
        public double? Duration { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        public double? Grade { get; set; }
        public string? Description { get; set; }

        /*----- Relations -----*/

        [ForeignKey(nameof(JobSeeker))]
        public int? JobSeekerId { get; set; }

        public JobSeeker? JobSeeker { get; set; }

    }
}