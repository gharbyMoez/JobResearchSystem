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
                                       IRequestHandler<UpdateSkillCommand, Response<GetSkillResponse>>
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
            var skill = _mapper.Map<Skill>(request);
            
            var result = await _skillService.AddSkillToJobseekerAsync(request.JobSeekerId, skill);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Skill Added Successfully");
        }

        public async Task<Response<GetSkillResponse>> Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
        {
            var skill = _mapper.Map<Skill>(request);

            var result = await _skillService.UpdateAsync(skill);

            var resultDto = _mapper.Map<GetSkillResponse>(request);

            if (resultDto == null) { return BadRequest<GetSkillResponse>(""); }
            else { return Success<GetSkillResponse>(resultDto); }
        }

        public async Task<Response<string>> Handle(DeleteSkillCommand request, CancellationToken cancellationToken)
        {
            var result = await _skillService.DeleteAsync(request.SkillId);

            if (!result) 
                return BadRequest<string>("");
            
            return Deleted<string>(""); 
        }

    }
}
