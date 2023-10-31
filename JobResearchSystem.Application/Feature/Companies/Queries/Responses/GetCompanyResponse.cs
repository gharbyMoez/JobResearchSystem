using JobResearchSystem.Domain.Entities;

namespace JobResearchSystem.Application.Feature.Companies.Queries.Responses
{
    public class GetCompanyResponse
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfJobs { get; set; } //perMonth
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }

        public ICollection<Job>? Jobs { get; set; }
    }
}
