using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using trimandstyle.com.AppDbContext;
using trimandstyle.com.Models;

namespace trimandstyle.com.Controllers
{
    public class CustomerController : Controller
    {
        private int IsRegistered = 0;
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

        public IActionResult RegisterCustomer(Customer customer)
        {
            int inserted = 0;
            var sql = "INSERT INTO Customers (Name, Address, ConfirmPassword, Email, IsAgreedTerms, IsEmailConfirmed, Password, PhoneNumber) VALUES (@Name, @Address, @ConfirmPassword, @Email, @IsAgreedTerms, @IsEmailConfirmed, @Password, @PhoneNumber)";
            using (var context = new TrimAndStyleDbContext())
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", customer.Name),
                    new SqlParameter("@Address", customer.Address),
                    new SqlParameter("@ConfirmPassword", customer.ConfirmPassword),
                    new SqlParameter("@Email", customer.Email),
                    new SqlParameter("@IsAgreedTerms", customer.IsAgreedTerms),
                    new SqlParameter("@IsEmailConfirmed", customer.IsEmailConfirmed),
                    new SqlParameter("@Password", customer.Password),
                    new SqlParameter("@PhoneNumber", customer.PhoneNumber),
                };

                inserted = context.Database.ExecuteSqlRaw(sql, parameters);

            }


            if (inserted > 0)
            {   
                //
                return RedirectToAction("Index", "Customer");
            }


        
                return RedirectToAction("Register", "Customer");

           
        }
    
    }
}
