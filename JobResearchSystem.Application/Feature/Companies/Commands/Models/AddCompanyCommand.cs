using JobResearchSystem.Application.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Application.Feature.Companies.Commands.Models
{
    public class AddCompanyCommand : IRequest<Response<string>>
    {
        public string CompanyName { get; set; }
        public int NumberOfJobs { get; set; } //perMonth
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }

        public string UserId { get; set; }
    }
}
