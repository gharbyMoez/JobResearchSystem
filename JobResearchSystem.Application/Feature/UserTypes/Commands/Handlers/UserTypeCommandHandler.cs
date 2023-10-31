using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.UserTypes.Commands.Models;
using JobResearchSystem.Application.Feature.UserTypes.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.UserTypes.Commands.Handlers
{
    public class UserTypeCommandHandler : ResponseHandler,
                                       IRequestHandler<AddUserTypeCommand, Response<string>>,
                                       IRequestHandler<DeleteUserTypeCommand, Response<string>>,
                                       IRequestHandler<UpdateUserTypeCommand, Response<GetUserTypeResponse>>
    {
        #region CTOR
        private IUserTypeService _UserTypeService;
        private IMapper _mapper;

        public UserTypeCommandHandler(IUserTypeService UserTypeSerice, IMapper mapper)
        {
            _UserTypeService = UserTypeSerice;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddUserTypeCommand request, CancellationToken cancellationToken)
        {
            var UserType = _mapper.Map<UserType>(request);
            var result = await _UserTypeService.CreateAsync(UserType);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" UserType Added Successfully");
        }

        public async Task<Response<GetUserTypeResponse>> Handle(UpdateUserTypeCommand request, CancellationToken cancellationToken)
        {
            var UserType = _mapper.Map<UserType>(request);

            var result = await _UserTypeService.UpdateAsync(UserType);

            var resultDto = _mapper.Map<GetUserTypeResponse>(request);

            if (resultDto == null) { return BadRequest<GetUserTypeResponse>(""); }
            else { return Success<GetUserTypeResponse>(resultDto); }
        }




        public async Task<Response<string>> Handle(DeleteUserTypeCommand request, CancellationToken cancellationToken)
        {
            var result = await _UserTypeService.DeleteAsync(request.UserTypeId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }

    }
}
