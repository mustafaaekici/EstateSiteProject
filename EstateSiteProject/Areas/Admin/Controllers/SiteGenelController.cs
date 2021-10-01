using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SiteGenelController : Controller
    {
        EmlakModel1 db = new EmlakModel1();
        // GET: Admin/SiteGenel
        public ActionResult Index()
        {
            var site = db.siteGenels.Where(s => s.siteGenelId == 1).FirstOrDefault();
            db.SaveChanges();
            return View(site);
        }

        public ActionResult Save(siteGenel siteGenel)
        {
            db.Entry(siteGenel).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return View("Index");
        }
    }
}