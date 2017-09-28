using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GeekBrainsShop.DAL.Employees;
using GeekBrainsShop.Domain.Employees;

namespace GeekBrainsShop.Controllers
{
    public class CatalogController : Controller
    {
        private LibraryContext dbContext = new LibraryContext();

        // GET: Catalog
        public ActionResult Index()
        {
            var footwear = dbContext.Footwear.Include(f => f.Trademark);
            return View(footwear.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Footwear footwear = dbContext.Footwear.Find(id);
            if (footwear == null)
            {
                return HttpNotFound();
            }
            return View(footwear);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
