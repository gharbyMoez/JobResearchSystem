using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Applicants.Commands.Models;
using JobResearchSystem.Application.Feature.Applicants.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.Applicants.Commands.Handlers
{
    public class ApplicantCommandHandler : ResponseHandler,
                                       IRequestHandler<AddApplicantCommand, Response<string>>,
                                       IRequestHandler<DeleteApplicantCommand, Response<string>>,
                                       IRequestHandler<UpdateApplicantCommand, Response<GetApplicantResponse>>
    {
        #region CTOR
        private IApplicantService _applicantService;
        private IMapper _mapper;

        public ApplicantCommandHandler(IApplicantService applicantService, IMapper mapper)
        {
            _applicantService = applicantService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddApplicantCommand request, CancellationToken cancellationToken)
        {
            var movie = _mapper.Map<Applicant>(request);
            var result = await _applicantService.CreateAsync(movie);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Applicant Added Successfully");
        }

        public async Task<Response<GetApplicantResponse>> Handle(UpdateApplicantCommand request, CancellationToken cancellationToken)
        {
            var Applicant = _mapper.Map<Applicant>(request);

            var result = await _applicantService.UpdateAsync(Applicant);

            var resultDto = _mapper.Map<GetApplicantResponse>(request);

            if (resultDto == null) { return BadRequest<GetApplicantResponse>(""); }
            else { return Success<GetApplicantResponse>(resultDto); }
        }

        public async Task<Response<string>> Handle(DeleteApplicantCommand request, CancellationToken cancellationToken)
        {
            var result = await _applicantService.DeleteAsync(request.ApplicantId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }

    }
}
