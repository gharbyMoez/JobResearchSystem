using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.JobSeekers.Commands.Models
{
    public class AddJobSeekerCommand : IRequest<Response<string>>
    {
        public string? CVFilePath { get; set; }
        public string? ImageFilePath { get; set; }
        public string UserId { get; set; }
    }
}
