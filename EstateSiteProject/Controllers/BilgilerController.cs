using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject.Controllers
{
    [Authorize(Roles ="Satici, Musteri")]
    public class BilgilerController : Controller
    {
        // GET: Bilgiler
        EmlakModel1 db = new EmlakModel1();
        public ActionResult Index()
        {
            int id = (int)Session["loginId"];
            var bilgi = db.Logins.Where(l => l.loginId == id).FirstOrDefault();
            db.SaveChanges();
            return View(bilgi);
        }

        public ActionResult Save(Login login)
        {
            var guncelle = db.Logins.Find(login.loginId);
            if (guncelle == null)
            {
                return HttpNotFound();
            }
            guncelle.loginAd = login.loginAd;
            guncelle.loginSoyad = login.loginSoyad;
            guncelle.loginEmail = login.loginEmail;
            guncelle.loginSifre = login.loginSifre;
            guncelle.telefonNo = login.telefonNo;
            db.SaveChanges();
            return View("Index");
        }
    }
}