using System.ComponentModel.DataAnnotations;

namespace casestuady2.Dtos
{
    public class MemberDtos
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

    }

    public class MemberCreateDtos
    {


        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;
    }
}
