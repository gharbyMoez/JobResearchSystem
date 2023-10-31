using AutoMapper;
using JobResearchSystem.Application.Feature.Companies.Commands.Models;
using JobResearchSystem.Application.Feature.Companies.Queries.Responses;
using JobResearchSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Application.Mapping.Companies
{
    public class CompaniesMappingProfile : Profile
    {
        public CompaniesMappingProfile()
        {
            CreateMap<Company, GetCompanyResponse>();

            CreateMap<AddCompanyCommand, Company>();
            CreateMap<UpdateCompanyCommand, Company>();
            CreateMap<DeleteCompanyCommand, Company>();

        }
    }
}
