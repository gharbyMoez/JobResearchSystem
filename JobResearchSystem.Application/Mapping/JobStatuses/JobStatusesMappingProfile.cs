using AutoMapper;
using JobResearchSystem.Application.Feature.JobStatus.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Experiences
{
    public class JobStatusesMappingProfile : Profile
    {
        public JobStatusesMappingProfile()
        {
            CreateMap<JobStatus, GetJobStatusResponse>();


        }
    }
}
