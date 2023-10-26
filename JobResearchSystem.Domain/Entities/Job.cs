using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Jobs")]
    public class Job : BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        //  public string? JobStatus { get; set; }//Changed By Admin
        public int? ApplicantsNumber { get; set; }
        public DateTime PublishDateTime { get; set; } = DateTime.Now;

        //Salary Range
        public double? RangeSalaryMin { get; set; }
        public double? RangeSalaryMax { get; set; }


        /*----- Relations -----*/

        [ForeignKey(nameof(Company))]
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        ////////////////

        public ICollection<Applicant>? Applicants { get; set; }

        ////////////////

        [ForeignKey(nameof(Category))]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        ////////////////

        [ForeignKey(nameof(JobStatus))]
        public int? JobStatusId { get; set; } = 1;
        public JobStatus? JobStatus { get; set; }
    }
}
