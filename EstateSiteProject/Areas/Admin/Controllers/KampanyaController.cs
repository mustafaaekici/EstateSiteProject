using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class KampanyaController : Controller
    {
        // GET: Admin/Kampanya
        EmlakModel1 db = new EmlakModel1();

        public ActionResult Index()
        {
            var kampanya = db.Kampanyas.ToList();
            return View(kampanya);
        }

        [HttpGet]
        public ActionResult KampanyaKaydet()
        {
            return View("KampanyaKaydet");
        }

        [HttpPost]
        public ActionResult KampanyaKaydet(Kampanya kampanya)
        {
            if (kampanya.kampanyaId == 0)
            {
                if (Request.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Image/" + dosyaAdi + uzanti;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    kampanya.kampanyaResim = "/Image/" + dosyaAdi + uzanti;
                }
                db.Kampanyas.Add(kampanya);
            }
            else
            {
                var kampanyaGuncelle = db.Kampanyas.Find(kampanya.kampanyaId);
                if (kampanyaGuncelle == null)
                {
                    return HttpNotFound();
                }
                kampanyaGuncelle.kampanyaAd = kampanya.kampanyaAd;
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Kampanya");
        }

        public ActionResult Guncelle(int id)
        {
            var kampanya = db.Kampanyas.Find(id);
            if (kampanya == null)
            {
                return HttpNotFound();
            }
            return View("KampanyaKaydet", kampanya);
        }

        public ActionResult Sil(int id)
        {
            var kampanyaSil = db.Kampanyas.Find(id);
            if (kampanyaSil == null)
            {
                return HttpNotFound();
            }
            db.Kampanyas.Remove(kampanyaSil);
            db.SaveChanges();
            return RedirectToAction("Index","Kampanya");
        }
    }
}