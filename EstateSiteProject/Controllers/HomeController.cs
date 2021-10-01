using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject.Controllers
{
    public class HomeController : Controller
    {
        EmlakModel1 db = new EmlakModel1();
        ViewModel vm = new ViewModel();
        // GET: Home
        
        [AllowAnonymous]
        public ActionResult Index()
        {
            vm.Ilan = db.ilans.ToList();
            vm.Kampanya = db.Kampanyas.ToList();
            return View(vm);
        }
        [Authorize]
        public ActionResult IlanDetay(int id)
        {
            vm.Ilan = db.ilans.Where(il => il.ilanId == id).ToList();
            return View(vm);
        }
    }
}