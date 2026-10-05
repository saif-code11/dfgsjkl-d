using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace casestuady2.Dtos
{
    public class BookDtos
    {
        public int Id { get; set; }

       
        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string ISBN { get; set; }

    
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
    }

    public class BookCreateDtos 
    {
       

        [Required]
        public string Title { get; set; } 

        [Required]
        public string Author { get; set; } 

        [Required]
        public string ISBN { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
    }
}
