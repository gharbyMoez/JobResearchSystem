using AutoMapper;
using JobResearchSystem.Application.Feature.Applicants.Commands.Models;
using JobResearchSystem.Application.Feature.Applicants.Queries.Response;
using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Mapping.Applicants
{
    public class ApplicantsMappingProfile : Profile
    {
        public ApplicantsMappingProfile()
        {
            CreateMap<Applicant, GetApplicantResponse>();
            CreateMap<UpdateApplicantCommand, GetApplicantResponse>();

            CreateMap<AddApplicantCommand, Applicant>();

            CreateMap<UpdateApplicantCommand, Applicant>();

        }
    }
}
