using System.ComponentModel.DataAnnotations.Schema;

namespace trimandstyle.com.Models
{
    public class Barber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerFK { get; set; }
    }
}
