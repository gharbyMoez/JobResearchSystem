using AutoMapper;
using JobResearchSystem.Application.DTOs.Authentication;
using JobResearchSystem.Application.Feature.Applicants.Commands.Models;
using JobResearchSystem.Application.Feature.Applicants.Queries.Response;
using JobResearchSystem.Domain.Entities;
using JobResearchSystem.Domain.Entities.Extend;

namespace JobResearchSystem.Application.Mapping.ApplicationUsers
{
    public class ApplicationUserMappingProfile : Profile
    {
        public ApplicationUserMappingProfile()
        {
            
            CreateMap<ApplicationUser, ResponseUserDetailsDto>().ReverseMap();
            CreateMap<ApplicationUser, UpdateUserDetailsDto>().ReverseMap();

        }
    }
}
