using GeekBrainsShop.DAL.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekBrainsShop.Controllers
{
    public class HomeController : Controller
    {
        private static LibraryContext dbContext = new LibraryContext();

        public ActionResult Index()
        {
            var employee = dbContext.Footwear;
            return View(employee.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}