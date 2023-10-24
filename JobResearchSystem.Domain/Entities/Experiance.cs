using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Experiances")]
    public class Experiance : BaseEntity
    {
        public string CompanyName { get; set; }

        public string Title { get; set; }

        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        public string? Description { get; set; }

        /*----- Relations -----*/

        [ForeignKey(nameof(JobSeeker))]
        public int JobSeekerId { get; set; }

        public JobSeeker JobSeeker { get; set; }

        //////////// ???

        //[ForeignKey(nameof(Company))]
        //public int? CompanyId { get; set; }

        //public Company? Company { get; set; }


    }
}
