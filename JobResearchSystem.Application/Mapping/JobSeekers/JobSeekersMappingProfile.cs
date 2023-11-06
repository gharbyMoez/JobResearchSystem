using AutoMapper;
using JobResearchSystem.Application.Feature.JobSeekers.Commands.Models;
using JobResearchSystem.Application.Feature.JobSeekers.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.JobSeekers
{
    public class JobSeekersMappingProfile : Profile
    {
        public JobSeekersMappingProfile()
        {
            CreateMap<JobSeeker, GetJobSeekerResponse>();
            CreateMap<JobSeeker, GetJobSeekerDetailsResponse>();
            CreateMap<UpdateJobSeekerCommand, GetJobSeekerResponse>();

            CreateMap<AddJobSeekerCommand, JobSeeker>();

            CreateMap<UpdateJobSeekerCommand, JobSeeker>();

        }
    }
}
