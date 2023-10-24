using System.ComponentModel.DataAnnotations.Schema;

namespace JobResearchSystem.Domain.Entities
{
    [Table("Categories")]
    public class Category : BaseEntity
    {

        public string CategoryName { get; set; }
        //public int CategoryParentId { get; set; }
        public string? Description { get; set; }

        /*----- Relations -----*/

        //public ICollection<Category>? SubCategories { get; set; }//Self Relation

        public ICollection<Job>? Jobs { get; set; }
    }
}
