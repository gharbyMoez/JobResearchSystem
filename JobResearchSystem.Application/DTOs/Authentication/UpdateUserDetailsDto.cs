#nullable disable

using System.ComponentModel.DataAnnotations;

namespace JobResearchSystem.Application.DTOs.Authentication
{
    public class UpdateUserDetailsDto
    {
        public string Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        
        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

    }
}
