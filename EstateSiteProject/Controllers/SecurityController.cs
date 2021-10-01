using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EstateSiteProject.Models.EntityFramework;
namespace EstateSiteProject.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {

        EmlakModel1 db = new EmlakModel1();
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
 
        public ActionResult Login(Login login)
        {
            var loginDb = db.Logins.FirstOrDefault(m => m.loginEmail == login.loginEmail && m.loginSifre == login.loginSifre);
            if (loginDb != null)
            {
                FormsAuthentication.SetAuthCookie(loginDb.loginAd, false);
                Session["loginAd"] = loginDb.loginAd;
                Session["loginId"] = loginDb.loginId;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Kullanıcı Adı veya Şifre";
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}