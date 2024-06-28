using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using trimandstyle.com.AppDbContext;
using trimandstyle.com.Models;

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

        public int RegisterCustomer(Customer customer)
        {
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

                int inserted = context.Database.ExecuteSqlRaw(sql, parameters);

                return (inserted > 0) ?  1 : 0;
            }


        }
    
    }
}
