using Hop.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hop.HR.Controllers
{
    public class HomeController : Controller
    {
        private readonly HopHrDataContext _db;

        public HomeController()
        {
            _db = new HopHrDataContext();
        }
        public  JsonResult AddNewEmployee (Employee model)
        {
            _db.Employees.Add(model);
            _db.SaveChanges();
            return Json("Successful!");
        }

        public JsonResult RemoveEmployee (Employee model)
        {
            _db.Employees.Remove(model);
            _db.SaveChanges();
            return Json("Removed Successsful!");
        }

         public JsonResult GetEmployees()
                {

                    var data = _db.Employees.ToList();

                    return Json(data, JsonRequestBehavior.AllowGet);
                }


                public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your Account ID";

            return View();
        }
    }
}



    