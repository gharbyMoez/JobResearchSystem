using AutoMapper;
using JobResearchSystem.Application.Feature.Experiences.Commands.Models;
using JobResearchSystem.Application.Feature.Experiences.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Experiences
{
    public class ExperiencesMappingProfile : Profile
    {
        public ExperiencesMappingProfile()
        {
            CreateMap<Experience, GetExperienceResponse>();
            CreateMap<UpdateExperienceCommand, GetExperienceResponse>();

            CreateMap<AddExperienceCommand, Experience>();

            CreateMap<UpdateExperienceCommand, Experience>();

        }
    }
}
