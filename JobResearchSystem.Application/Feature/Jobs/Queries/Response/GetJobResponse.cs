using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Feature.Jobs.Queries.Response
{
    public class GetJobResponse
    {
        public int Id { get; set; }
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

        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public int NumberOfApplicants { get; set; }

        public int? JobStatusId { get; set; } = 1;
    }
}
