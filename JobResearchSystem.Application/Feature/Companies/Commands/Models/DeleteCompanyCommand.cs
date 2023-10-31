using JobResearchSystem.Application.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Application.Feature.Companies.Commands.Models
{
    public class DeleteCompanyCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
    }
}
