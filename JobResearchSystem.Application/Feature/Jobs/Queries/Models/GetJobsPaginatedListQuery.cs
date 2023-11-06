using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Jobs.Queries.Response;
using JobResearchSystem.Application.Wrappers;
using MediatR;

namespace JobResearchSystem.Application.Feature.Jobs.Queries.Models
{
    public class GetJobPaginatedListQuery : IRequest<PaginatedResult<GetPaginatedJobResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public string? Search {  get; set; }
    }
}
