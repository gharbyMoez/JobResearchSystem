using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.UserTypes.Commands.Models
{
    public class DeleteUserTypeCommand : IRequest<Response<string>>
    {
        public int UserTypeId { get; set; }
    }
}
