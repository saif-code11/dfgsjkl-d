using System.ComponentModel.DataAnnotations;

namespace casestuady2.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } 

        [MaxLength(200)]
        public string? Description { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
