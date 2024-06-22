using System.ComponentModel.DataAnnotations;

namespace trimandstyle.com.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}
