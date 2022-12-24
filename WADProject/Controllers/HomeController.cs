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
        public List<string?> GetDonors()
        {
            return _Db.DonorData.Select(c => c.Donor).ToList();
        }
        public List<string?> GetRecipient()
        {
            return _Db.RecipientData.Select(c => c.Recipient).ToList();
        }
        public List<int?> GetCno()
        {
            return _Db.bloodReqData.Select(c => c.controlNo).ToList();
        }
        [HttpGet]
        public IActionResult Donor()
        {
                List<DonorModel>? listofdata = _Db.DonorData.ToList();
                return View(listofdata);
        }
        [HttpPost]
        public IActionResult Donor(DonorModel model)
        {
            _Db.DonorData.Add(model);
            _Db.SaveChanges();
            return RedirectToAction("Donor",new {HTTPVerb = "GET"});
        }
        public ActionResult DeleteDonor(int id)
        {
            var data = _Db.DonorData.Where(x => x.DonorId == id).FirstOrDefault();
            _Db.DonorData.Remove(data);
            _Db.SaveChanges();
            return RedirectToAction("Donor");
        }
        public IActionResult Recipient()
        {
                List<RecipientModel>? listofdata = _Db.RecipientData.ToList();
                return View(listofdata);
        }
        [HttpPost]
        public IActionResult Recipient(RecipientModel model)
        {
            _Db.RecipientData.Add(model);
            _Db.SaveChanges();
            return RedirectToAction("Recipient", new { HTTPVerb = "GET" });
        }
        public ActionResult DeleteRecipient(int id)
        {
            var data = _Db.RecipientData.Where(x => x.RecipientId == id).FirstOrDefault();
            _Db.RecipientData.Remove(data);
            _Db.SaveChanges();
            return RedirectToAction("Recipient");
        }
        public IActionResult Blood_Collection()
        {
            List<BloodCollectionModel>? listofdata = _Db.bloodCollectData.ToList();
            ViewBag.Donors = GetDonors();
            return View(listofdata);
        }
        [HttpPost]
        public IActionResult Blood_Collection(BloodCollectionModel model)
        {
            _Db.bloodCollectData.Add(model);
            _Db.SaveChanges();
            return RedirectToAction("Blood_Collection", new {HTTPVerb = "GET"});
        }
        public ActionResult DeleteBloodCol(int id)
        {
            var data = _Db.bloodCollectData.Where(x => x.BloodColId == id).FirstOrDefault();
            _Db.bloodCollectData.Remove(data);
            _Db.SaveChanges();
            return RedirectToAction("Blood_Collection");
        }
        public IActionResult Blood_Request()
        {
            List<BloodRequestModel>? listofdata = _Db.bloodReqData.ToList();
            ViewBag.Recipient = GetRecipient();
            return View(listofdata);
        }
        [HttpPost]
        public IActionResult Blood_Request(BloodRequestModel model)
        {
            _Db.bloodReqData.Add(model);
            _Db.SaveChanges();
            return RedirectToAction("Blood_Request", new {HTTPVerb = "GET"});
        }
        public ActionResult DeleteBloodReq(int id)
        {
            var data = _Db.bloodReqData.Where(x => x.BloodReqId == id).FirstOrDefault();
            _Db.bloodReqData.Remove(data);
            _Db.SaveChanges();
            return RedirectToAction("Blood_Request");
        }
        public IActionResult Blood_Issued()
        {
            List<BloodIssuedModel>? listofdata = _Db.bloodIssuedData.ToList();
            ViewBag.ControlNo = GetCno();
            return View(listofdata);
        }
        [HttpPost]
        public IActionResult Blood_Issued(BloodIssuedModel model)
        {
            _Db.bloodIssuedData.Add(model);
            _Db.SaveChanges();
            return RedirectToAction("Blood_Issued", new {HTTPVerb = "GET"});
        }
        public ActionResult DeleteBloodIssued(int id)
        {
            var data = _Db.bloodIssuedData.Where(x => x.BloodIsudId == id).FirstOrDefault();
            _Db.bloodIssuedData.Remove(data);
            _Db.SaveChanges();
            return RedirectToAction("Blood_Issued");
        }
        public IActionResult User_Accounts()
        {
            List<userAccountsModel>? listofdata = _Db.Accounts.ToList();
            return View(listofdata);
        }
        [HttpPost]
        public IActionResult User_Accounts(userAccountsModel model)
        {
            _Db.Accounts.Add(model);
            _Db.SaveChanges();
            return RedirectToAction("User_Accounts", new {HTTPVerb = "GET"});
        }
        public ActionResult DeleteAccount(int id)
        {
            var data = _Db.Accounts.Where(x => x.AccId == id).FirstOrDefault();
            _Db.Accounts.Remove(data);
            _Db.SaveChanges();
            return RedirectToAction("User_Accounts");
        }
        public IActionResult User_Logs()
        {
            List<logsModel>? listofdata = _Db.logsData.ToList();
            return View(listofdata);
        }
    }
}
