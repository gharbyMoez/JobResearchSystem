using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Skills.Commands.Models;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Commands.Handlers
{
    public class SkillCommandHandler : ResponseHandler,
                                       IRequestHandler<AddSkillCommand, Response<string>>,
                                       IRequestHandler<DeleteSkillCommand, Response<string>>,
                                       IRequestHandler<UpdateSkillCommand, Response<GetJobResponse>>
    {
        #region CTOR
        private ISkillService _skillService;
        private IMapper _mapper;

        public SkillCommandHandler(ISkillService skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddSkillCommand request, CancellationToken cancellationToken)
        {
            var movie = _mapper.Map<Skill>(request);
            var result = await _skillService.AddSkillAsync(movie);
            if (result != "success")
            { return BadRequest<string>("Something Went Wrong"); }
            else { return Created(" Skill Added Successfully"); }
        }

        public async Task<Response<GetJobResponse>> Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
        {
            var skill = _mapper.Map<Skill>(request);
            var result = await _skillService.UpdateSkillAsync(skill);
            var resultDto = _mapper.Map<GetJobResponse>(request);
            if (resultDto == null) { return BadRequest<GetJobResponse>(""); }
            else { return Success<GetJobResponse>(resultDto); }
        }

        public async Task<Response<string>> Handle(DeleteSkillCommand request, CancellationToken cancellationToken)
        {
            var result = await _skillService.DeleteSkillAsync(request.SkillId);

            if (result != "success")
            {
                return BadRequest<string>("");
            }
            else { return Deleted<string>(result); }
        }

    }
}
