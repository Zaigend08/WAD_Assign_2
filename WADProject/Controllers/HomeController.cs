using Microsoft.AspNetCore.Mvc;
using WADProject.Models;

namespace WADProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _Db;
        public HomeController(AppDbContext Db)
        {
            _Db = Db;
        }
        [HttpGet]
        public IActionResult Donor()
        {
            try
            {
                List<DonorModel>? listofdata = _Db.DonorData.ToList();
                return View(listofdata);
            }
            catch { };
                return View();

        }
        [HttpPost]
        public IActionResult Donor(DonorModel model)
        {
            Console.WriteLine(model);
            _Db.DonorData.Add(model);
            _Db.SaveChanges();
            return RedirectToAction("Donor",new {HTTPVerb = "GET"});
        }
        /*public IActionResult Recipient()
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
        }*/
    }
}
