using AutoMapper;
using JobResearchSystem.Application.Bases;
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
                                       IRequestHandler<UpdateQualificationCommand, Response<GetQualificationResponse>>
    {
        #region CTOR
        private IQualificationService _qualificationService;
        private IMapper _mapper;

        public QualificationCommandHandler(IQualificationService qualificationService, IMapper mapper)
        {
            _qualificationService = qualificationService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddQualificationCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Qualification>(request);
            var result = await _qualificationService.CreateAsync(experiene);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Skill Added Successfully");
        }

        public async Task<Response<GetQualificationResponse>> Handle(UpdateQualificationCommand request, CancellationToken cancellationToken)
        {
            var experiene = _mapper.Map<Qualification>(request);

            var result = await _qualificationService.UpdateAsync(experiene);

            var resultDto = _mapper.Map<GetQualificationResponse>(request);

            if (resultDto == null) { return BadRequest<GetQualificationResponse>(""); }
            else { return Success<GetQualificationResponse>(resultDto); }
        }




        public async Task<Response<string>> Handle(DeleteQualificationCommand request, CancellationToken cancellationToken)
        {
            var result = await _qualificationService.DeleteAsync(request.QualificationId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }

    }
}
