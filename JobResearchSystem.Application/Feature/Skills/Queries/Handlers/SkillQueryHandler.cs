﻿using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Skills.Queries.Models;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using JobResearchSystem.Application.IService;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Queries.Handlers
{
    public class JobQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllJobsQuery, Response<IEnumerable<GetJobResponse>>>,
                                     IRequestHandler<GetJobByIdQuery, Response<GetJobResponse>>
    {
        #region CTOR
        private ISkillService _skillService;
        private IMapper _mapper;

        public JobQueryHandler(ISkillService skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetJobResponse>>> Handle(GetAllJobsQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _skillService.GetAllSkillsAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetJobResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetJobResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetJobResponse>> Handle(GetJobByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _skillService.GetSkillByIdAsync(request.SkillId);

            if (entity == null)
            {
                return NotFound<GetJobResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetJobResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
}
