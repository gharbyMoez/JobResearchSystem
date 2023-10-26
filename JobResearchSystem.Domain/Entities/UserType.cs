using JobResearchSystem.Domain.Entities.Extend;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("UserTypes")]
    public class UserType : BaseEntity
    {
        [Key]
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        /*----- Relations -----*/

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
