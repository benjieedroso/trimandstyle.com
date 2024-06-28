using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trimandstyle.com.AppDbContext;
using trimandstyle.com.Models;

namespace trimandstyle.com.Controllers
       
{
    public class BarberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<Customer> CreateProfile(Barber barber)
        {   
            using (var context = new TrimAndStyleDbContext())
            {
                var allCustomer = context.Customers.FromSqlRaw("Select * from Customers").ToList();
                return allCustomer;
            }
        }
    }
}

