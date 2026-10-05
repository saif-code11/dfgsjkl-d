using casestuady2.Models;
using System.ComponentModel.DataAnnotations;

namespace casestuady2.Dtos
{
    public class BookingDtos
    {

        public int Id { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int MemberId { get; set; }


        public int BookId { get; set; }

    }

    public class BoojingCreateDto 
    {


        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int MemberId { get; set; }

        public Customer Member { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
    }

}
