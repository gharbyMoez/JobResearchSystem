using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Experiences.Commands.Models;
using JobResearchSystem.Application.Feature.Experiences.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.Experiences.Commands.Handlers
{
    public class ExperienceCommandHandler : ResponseHandler,
                                       IRequestHandler<AddExperienceCommand, Response<string>>,
                                       IRequestHandler<DeleteExperienceCommand, Response<string>>,
                                       IRequestHandler<UpdateExperienceCommand, Response<GetExperienceResponse>>
    {
        #region CTOR
        private IExperienceService _experienceService;
        private IMapper _mapper;

        public ExperienceCommandHandler(IExperienceService ExperienceSerice, IMapper mapper)
        {
            _experienceService = ExperienceSerice;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddExperienceCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Experience>(request);
            var result = await _experienceService.CreateAsync(experiene);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Skill Added Successfully");
        }

        public async Task<Response<GetExperienceResponse>> Handle(UpdateExperienceCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Experience>(request);

            var result = await _experienceService.UpdateAsync(experiene);

            var resultDto = _mapper.Map<GetExperienceResponse>(request);

            if (resultDto == null) { return BadRequest<GetExperienceResponse>(""); }
            else { return Success<GetExperienceResponse>(resultDto); }
        }




        public async Task<Response<string>> Handle(DeleteExperienceCommand request, CancellationToken cancellationToken)
        {
            var result = await _experienceService.DeleteAsync(request.ExperienceId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }

    }
}
