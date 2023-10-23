using System.ComponentModel.DataAnnotations;

namespace TheHenkAPI.Classes
{
    public class Category
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Item>? Items { get; set; }

    }
}
