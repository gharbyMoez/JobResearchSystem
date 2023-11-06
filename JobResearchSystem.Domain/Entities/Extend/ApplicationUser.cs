using Microsoft.AspNetCore.Identity;

namespace JobResearchSystem.Domain.Entities.Extend
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


        public bool IsDeleted { get; set; } = false;
        public DateTime? DateDeleted { get; set; }


        /*----- Relations -----*/

        //[ForeignKey(nameof(JobSeeker))]
        //public int? JobSeekerId { get; set; }
        //public JobSeeker? JobSeeker { get; set; }

        ////////////////////

        //[ForeignKey(nameof(Company))]
        //public int? CompanyId { get; set; }
        //public Company? Company { get; set; }

        //////////////////

        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
    }
}
