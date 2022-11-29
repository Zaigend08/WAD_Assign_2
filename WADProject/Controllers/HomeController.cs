using Microsoft.AspNetCore.Mvc;

namespace WADProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Donor()
        {
            return View();
        }
        public IActionResult Recipient()
        {
            return View();
        }
        public IActionResult Blood_Collection()
        {
            return View();
        }
        public IActionResult Blood_Request()
        {
            return View();
        }
        public IActionResult Blood_Issued()
        {
            return View();
        }
        public IActionResult User_Accounts()
        {
            return View();
        }
        public IActionResult User_Logs()
        {
            return View();
        }
    }
}
