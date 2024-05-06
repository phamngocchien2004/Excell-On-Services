using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Excell_On.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult History()
        {
            return View("History");
        }
        public ActionResult Invoice()
        {
            return View("Invoice");
        }
        public ActionResult CustomerList()
        {
            return View("CustomerList");
        }
        public ActionResult CustomerDetail()
        {
            return View("CustomerDetail");
        }
        public ActionResult Department()
        {
            return View("Department");
        }
    }
}