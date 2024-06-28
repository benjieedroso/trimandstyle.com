using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using trimandstyle.com.AppDbContext;
using trimandstyle.com.Models;

namespace trimandstyle.com.Controllers
       
{
    public class BarberController : Controller
    {   
        public string queryMessage = "";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProfile(Barber barber)
        {
            var vm = new MessageViewModel();

            using (var context = new TrimAndStyleDbContext())
            {
                var sql = "INSERT INTO Barbers (Name, Specialty) values( @Name, @Specialty)";
                
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", barber.Name),
                    new SqlParameter("@Specialty", barber.Specialty)
                };


                var allCustomer = context.Customers.FromSqlRaw(sql);
                int inserted = context.Database.ExecuteSqlRaw(sql, parameters);
               

                
            }
            return RedirectToAction("Index", "Barber");
        }
    }
}

