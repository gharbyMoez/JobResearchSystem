#nullable disable

using System.ComponentModel.DataAnnotations;

namespace JobResearchSystem.Application.DTOs.Authentication
{
    public class UpdateUserDetailsDto
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string FirstName {  get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }

    }
}
