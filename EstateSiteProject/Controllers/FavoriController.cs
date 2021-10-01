using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject.Controllers
{
    [Authorize]
    public class FavoriController : Controller
    {
        EmlakModel1 db = new EmlakModel1();
        // GET: Favori
        public ActionResult Index()
        {
            int id = (int)Session["loginId"];
            var fav = db.Favorilers.Where(l => l.loginId == id).ToList();
            //var fav = db.Favorilers.ToList();
            return View(fav);
        }

        public ActionResult FavoriEkle(int id)
        {
            int logId = (int)Session["loginId"];
            var fav = db.Favorilers.FirstOrDefault(f => f.ilanId == id && f.loginId == logId);
            if (fav == null)
            {
                var newFav = new Favoriler { ilanId=id,loginId=logId };
                db.Favorilers.Add(newFav);
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FavoriSil(int id)
        {
            int logId = (int)Session["loginId"];
            var silinecekFav = db.Favorilers.FirstOrDefault(f => f.ilanId == id && f.loginId == logId);
            if (silinecekFav == null)
            {
                return HttpNotFound();
            }
            db.Favorilers.Remove(silinecekFav);
            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}