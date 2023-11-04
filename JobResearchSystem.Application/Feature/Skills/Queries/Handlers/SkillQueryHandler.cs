using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Skills.Queries.Models;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Queries.Handlers
{
    public class SkillQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllSkillsQuery, Response<IEnumerable<GetSkillResponse>>>,
                                     IRequestHandler<GetAllSkillsByJobSeekerIdQuery, Response<IEnumerable<GetSkillResponse>>>,
                                     IRequestHandler<GetSkillByIdQuery, Response<GetSkillResponse>>
    {
        #region CTOR
        private ISkillService _skillService;
        private IMapper _mapper;

        public SkillQueryHandler(ISkillService skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetSkillResponse>>> Handle(GetAllSkillsQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _skillService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetSkillResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetSkillResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetSkillResponse>> Handle(GetSkillByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _skillService.GetByIdAsync(request.SkillId);

            if (entity == null)
            {
                return NotFound<GetSkillResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetSkillResponse>(entity);

                return Success(entityMapped);
            }
        }

        public async Task<Response<IEnumerable<GetSkillResponse>>> Handle(GetAllSkillsByJobSeekerIdQuery request, CancellationToken cancellationToken)
        {
            var entityList = await _skillService.GetAllSkillByJobseekerIdAsync(request.JobSeekerId);

            if (entityList == null)
                return NotFound<IEnumerable<GetSkillResponse>>("Sorry, There is no data to display!");

            var entityListMapped = _mapper.Map<IEnumerable<GetSkillResponse>>(entityList);

            return Success(entityListMapped);
        }
    }
}
