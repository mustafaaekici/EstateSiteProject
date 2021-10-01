using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminHomeController : Controller
    {
        EmlakModel1 db = new EmlakModel1();

        // GET: Admin/AdminHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult saticiGoster()
        {
            var satici = db.Logins.Where(s => s.Rol == "Satici").ToList();
            return View("TabloGoster", satici);
        }

        public ActionResult musteriGoster()
        {
            var musteri = db.Logins.Where(m => m.Rol=="Musteri").ToList();
            return View("TabloGoster", musteri);
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View("AdminForm");
        }
        [HttpPost]
        public ActionResult Kaydet(Login login)
        {
            if (login.loginId == 0 )
            {
                db.Logins.Add(login);
            }
            else
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
                guncelle.Rol = login.Rol;
                guncelle.telefonNo = login.telefonNo;
            }
            db.SaveChanges();
            return RedirectToAction("Index","AdminHome");
        }
        public ActionResult Guncelle(int id)
        {
            var model = db.Logins.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("AdminForm",model);
        }

        public ActionResult Sil(int id)
        {
            var silinecek = db.Logins.Find(id);
            if (silinecek == null)
            {
                return HttpNotFound();
            }
            db.Logins.Remove(silinecek);
            db.SaveChanges();
            return RedirectToAction("Index", "AdminHome");
        }
    }
}