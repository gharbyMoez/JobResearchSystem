using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Experiences.Queries.Models;
using JobResearchSystem.Application.Feature.Experiences.Queries.Response;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.Experiences.Queries.Handlers
{
    public class ExperienceQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllExperiencesQuery, Response<IEnumerable<GetExperienceResponse>>>,
                                     IRequestHandler<GetAllExperiencesByJobSeekerIdQuery, Response<IEnumerable<GetExperienceResponse>>>,
                                     IRequestHandler<GetExperienceByIdQuery, Response<GetExperienceResponse>>
    {
        #region CTOR
        private IExperienceService _experienceService;
        private IMapper _mapper;

        public ExperienceQueryHandler(IExperienceService experienceService, IMapper mapper)
        {
            _experienceService = experienceService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetExperienceResponse>>> Handle(GetAllExperiencesQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _experienceService.GetAllAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetExperienceResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetExperienceResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetExperienceResponse>> Handle(GetExperienceByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _experienceService.GetByIdAsync(request.ExperienceId);

            if (entity == null)
            {
                return NotFound<GetExperienceResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetExperienceResponse>(entity);


                return Success(entityMapped);
            }
        }

        public async Task<Response<IEnumerable<GetExperienceResponse>>> Handle(GetAllExperiencesByJobSeekerIdQuery request, CancellationToken cancellationToken)
        {
            var entityList = await _experienceService.GetAllExperiencesByJobseekerIdAsync(request.JobSeekerId);

            if (entityList == null)
                return NotFound<IEnumerable<GetExperienceResponse>>("Sorry, There is no data to display!");

            var entityListMapped = _mapper.Map<IEnumerable<GetExperienceResponse>>(entityList);

            return Success(entityListMapped);
        }
    }
}
