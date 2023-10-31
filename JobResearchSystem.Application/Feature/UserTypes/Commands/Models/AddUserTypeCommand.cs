using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.UserTypes.Commands.Models
{
    public class AddUserTypeCommand : IRequest<Response<string>>
    {
        public string UserTypeName { get; set; }

    }
}
