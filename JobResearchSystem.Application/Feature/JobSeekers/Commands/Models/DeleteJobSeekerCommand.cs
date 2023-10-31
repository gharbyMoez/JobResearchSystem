using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.JobSeekers.Commands.Models
{
    public class DeleteJobSeekerCommand : IRequest<Response<string>>
    {
        public int JobSeekerId { get; set; }
    }
}
