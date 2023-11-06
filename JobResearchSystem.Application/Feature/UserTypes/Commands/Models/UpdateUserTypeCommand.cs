using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.UserTypes.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.UserTypes.Commands.Models
{
    public class UpdateUserTypeCommand : IRequest<Response<GetUserTypeResponse>>
    {
        public int Id { get; set; }
        public string UserTypeName { get; set; }


    }
}
