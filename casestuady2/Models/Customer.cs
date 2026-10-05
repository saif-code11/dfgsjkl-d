using System.ComponentModel.DataAnnotations;

namespace casestuady2.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } 

        [Required]
        public string Phone { get; set; } 

        public ICollection<Borrowing> Borrowings { get; set; }
            = new List<Borrowing>();
    }
}
