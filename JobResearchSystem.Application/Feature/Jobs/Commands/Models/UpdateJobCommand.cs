using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Jobs.Commands.Models
{
    public class UpdateJobCommand : IRequest<Response<GetJobResponse>>
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

        public int CompanyId { get; set; }
        public int CategoryId { get; set; }

        public int? JobStatusId { get; set; } = 1;
    }
}
