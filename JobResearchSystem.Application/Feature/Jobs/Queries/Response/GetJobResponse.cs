namespace JobResearchSystem.Application.Feature.Jobs.Queries.Response
{
    public class GetJobResponse
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int? ApplicantsNumber { get; set; }
        public double? RangeSalaryMin { get; set; }
        public double? RangeSalaryMax { get; set; }
    }
}
