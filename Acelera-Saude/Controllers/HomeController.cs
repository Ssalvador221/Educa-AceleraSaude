using Acelera_Saude.Models;
using Firebase.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Acelera_Saude.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var token = HttpContext.Session.GetString("_UserToken");

            if(token == null)
            {
                return RedirectToAction("Login", "Auth", new { page = "Login"});
            }
            else
            {
                return View();
            }
        }

        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}