using AutoMapper;
using JobResearchSystem.Application.Feature.Jobs.Commands.Models;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Experiences
{
    public class JobsMappingProfile : Profile
    {
        public JobsMappingProfile()
        {
            CreateMap<Job, GetJobResponse>();
            CreateMap<UpdateJobCommand, GetJobResponse>();

            CreateMap<AddJobCommand, Job>();

            CreateMap<UpdateJobCommand, Job>();

        }
    }
}
