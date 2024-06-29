using System.ComponentModel.DataAnnotations.Schema;

namespace trimandstyle.com.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Barber Barber { get; set; }

        [ForeignKey(nameof(Barber))]
        public int BarberFK
        {
            get; set;
        }
        public Customer Customer { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerFK { get; set; }

        public DateTime DateTime { get; set; }

    }
}
