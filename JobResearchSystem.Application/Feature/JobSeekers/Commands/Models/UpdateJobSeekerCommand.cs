using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.JobSeekers.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.JobSeekers.Commands.Models
{
    public class UpdateJobSeekerCommand : IRequest<Response<GetJobSeekerResponse>>
    {
        public int Id { get; set; }
        public string? CVFilePath { get; set; }
        public string? ImageFilePath { get; set; }

    }
}
