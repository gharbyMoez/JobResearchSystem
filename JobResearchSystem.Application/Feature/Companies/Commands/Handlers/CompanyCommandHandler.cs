using AutoMapper;
using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Companies.Commands.Models;
using JobResearchSystem.Application.Feature.Companies.Queries.Models;
using JobResearchSystem.Application.Feature.Companies.Queries.Responses;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Application.Services;
using JobResearchSystem.Domain.Entities;
using MediatR;

namespace JobResearchSystem.Application.Feature.Companies.Commands.Handlers
{
    public class CompanyCommandHandler : ResponseHandler,
                                     IRequestHandler<AddCompanyCommand, Response<string>>,
                                     IRequestHandler<UpdateCompanyCommand, Response<GetCompanyResponse>>,
                                     IRequestHandler<DeleteCompanyCommand, Response<string>>
    {
        #region CTOR
        private readonly ICompanyService _companyService;
        private IMapper _mapper;

        public CompanyCommandHandler(ICompanyService companyService, IMapper mapper)
        {
            this._companyService = companyService;
            _mapper = mapper;
        }
        #endregion


        public async Task<Response<string>> Handle(AddCompanyCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Company>(request);
            var result = await _companyService.CreateAsync(entity);
            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Skill Added Successfully");
        }

        public async Task<Response<GetCompanyResponse>> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Company>(request);

            var result = await _companyService.UpdateAsync(entity);

            var mappedEntity = _mapper.Map<GetCompanyResponse>(result);

            if (mappedEntity == null) { return BadRequest<GetCompanyResponse>(""); }
            else { return Success(mappedEntity); }
        }

        public async Task<Response<string>> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var result = await _companyService.DeleteAsync(request.Id);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }


    }
}
