using JobResearchSystem.Domain.Entities.Extend;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("UserTypes")]
    public class UserType : BaseEntity
    {
        public string UserTypeName { get; set; }

        /*----- Relations -----*/

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
