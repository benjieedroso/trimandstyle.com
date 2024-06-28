using System.ComponentModel.DataAnnotations;

namespace trimandstyle.com.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword {  get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public bool IsEmailConfirmed { get; set; }
        public bool IsAgreedTerms { get; set; }

    }
}
