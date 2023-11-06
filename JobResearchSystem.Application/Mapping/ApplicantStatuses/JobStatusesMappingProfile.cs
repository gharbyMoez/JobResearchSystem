using AutoMapper;
using JobResearchSystem.Application.Feature.ApplicantStatus.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Experiences
{
    public class ApplicantStatusesMappingProfile : Profile
    {
        public ApplicantStatusesMappingProfile()
        {
            CreateMap<ApplicantStatus, GetApplicantStatusResponse>();


        }
    }
}
