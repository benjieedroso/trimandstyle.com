using Microsoft.AspNetCore.Mvc;

namespace trimandstyle.com.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {

        return View(); 
        }

        public IActionResult Login()
        {
            return View();
        }
    
    }
}
