using System.ComponentModel.DataAnnotations;

namespace casestuady2.Dtos
{
    public class CategoryDtos
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }
    }

    public class CategoryCreate
    {

        [Required]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
