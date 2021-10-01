using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject.Controllers
{
 [AllowAnonymous]
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            EmlakModel1 db = new EmlakModel1();
            Login log = new Login();

            log.loginAd = form["loginAd"].Trim();
            log.loginSoyad = form["loginSoyad"].Trim();
            log.loginEmail = form["loginEmail"].Trim();
            log.loginSifre = form["loginSifre"].Trim();
            log.Rol = form["Rol"].Trim();
            log.telefonNo = form["telefonNo"].Trim();

            db.Logins.Add(log);
            db.SaveChanges();

            return View();
        }
    } 
}