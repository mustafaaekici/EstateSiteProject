using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateSiteProject.Areas.Sellers.ViewModels;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject.Areas.Sellers.Controllers
{
    [Authorize(Roles = "Satici")]
    public class SellersHomeController : Controller
    {
        EmlakModel1 db = new EmlakModel1();
        // GET: Sellers/Home
        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult IlanGoster()
        {
            int id = (int)Session["loginId"];
            var listele = db.ilans.Where(l => l.loginId == id).ToList();         
            return View(listele);
        }
        
        public ActionResult YeniIlan()
        {
            var model = new IlanFormViewModel() {
                Kategoris = db.Kategoris.ToList(),
                SatisTipis = db.SatisTipis.ToList()
            };
            return View("IlanForm", model);
        }
        [HttpPost]
        public ActionResult Kaydet(ilan ilan)
        {
            if (ilan.ilanId == 0)  // Veri yoksa ekle
            {
                if (Request.Files.Count>0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Image/" + dosyaAdi + uzanti;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    ilan.ilanResim = "/Image/" + dosyaAdi + uzanti;
                }
                ilan.loginId = (int)Session["loginId"];
                db.ilans.Add(ilan);
            }
            else  // Varsa güncelle
            {
                //if (ilan.DetayId.GetValueOrDefault() != 0)
                //{
                //    ilan.DetayId = ilan.DetayId;
                //}
                ilan.loginId = (int)Session["loginId"];
                db.Entry(ilan).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();
            return RedirectToAction("IlanGoster", "SellersHome");
        }

        public ActionResult Guncelle(int id)
        {
            var model = new IlanFormViewModel()
            {
                Kategoris = db.Kategoris.ToList(),
                SatisTipis = db.SatisTipis.ToList(),
                ilan = db.ilans.Find(id)
            };
            return View("IlanForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekIlan = db.ilans.Find(id);
            if (silinecekIlan == null)
            {
                return HttpNotFound();
            }
            db.ilans.Remove(silinecekIlan);
            db.SaveChanges();
            return RedirectToAction("IlanGoster", "SellersHome");
        }
    }
}