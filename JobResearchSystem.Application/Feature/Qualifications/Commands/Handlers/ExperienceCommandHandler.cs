using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Experiences.Commands.Models;
using JobResearchSystem.Application.Feature.Experiences.Queries.Response;
using JobResearchSystem.Application.Feature.Qualifications.Commands.Models;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.Qualifications.Commands.Handlers
{
    public class QualificationCommandHandler : ResponseHandler,
                                       IRequestHandler<AddQualificationCommand, Response<string>>,
                                       IRequestHandler<DeleteQualificationCommand, Response<string>>,
                                       IRequestHandler<UpdateQualificationCommand, Response<GetExperienceResponse>>
    {
        #region CTOR
        private IQualificationService _experienceService;
        private IMapper _mapper;

        public QualificationCommandHandler(IQualificationService ExperienceSerice, IMapper mapper)
        {
            _experienceService = ExperienceSerice;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddQualificationCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Qualification>(request);
            var result = await _experienceService.CreateAsync(experiene);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Skill Added Successfully");
        }

        public async Task<Response<GetQualificationResponse>> Handle(UpdateQualificationCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Qualification>(request);

            var result = await _experienceService.UpdateAsync(experiene);

            var resultDto = _mapper.Map<GetQualificationResponse>(request);

            if (resultDto == null) { return BadRequest<GetQualificationResponse>(""); }
            else { return Success<GetQualificationResponse>(resultDto); }
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
