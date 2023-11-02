using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Companies.Queries.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Application.Feature.Companies.Commands.Models
{
    public class UpdateCompanyCommand : IRequest<Response<GetCompanyResponse>>
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfJobs { get; set; } //perMonth
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }

        public string UserId { get; set; }

    }
}
