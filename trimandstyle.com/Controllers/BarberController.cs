using Microsoft.AspNetCore.Mvc;
using trimandstyle.com.Models;

namespace trimandstyle.com.Controllers
{
    public class BarberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Store(Barber barber)
        {

            return barber.Name;
        }
        }
    }

