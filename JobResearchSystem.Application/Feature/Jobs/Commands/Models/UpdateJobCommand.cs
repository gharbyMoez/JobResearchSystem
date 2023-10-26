using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Jobs.Commands.Models
{
    public class UpdateJobCommand : IRequest<Response<GetJobResponse>>
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int? ApplicantsNumber { get; set; }
        public double? RangeSalaryMin { get; set; }
        public double? RangeSalaryMax { get; set; }
    }
}
