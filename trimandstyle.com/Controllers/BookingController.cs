using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using trimandstyle.com.AppDbContext;
using trimandstyle.com.Models;

namespace trimandstyle.com.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            var barbers = GetBarbers();
            return View(barbers);
        }

        public List<Barber> GetBarbers()
        {
            var BarbersList = new List<Barber>();

            using (var context = new TrimAndStyleDbContext())
            {
                BarbersList = context.Barbers.FromSqlRaw("SELECT * FROM Barbers").ToList();
            }

            return BarbersList;
        }

        public Booking Book(Booking booking)
        {
            return booking;
        }

       
    }
}
