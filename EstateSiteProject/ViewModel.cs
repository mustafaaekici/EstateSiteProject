using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstateSiteProject.Models.EntityFramework;

namespace EstateSiteProject
{
    public class ViewModel
    {
        public List<ilan> Ilan { get; set; }
        public List<Kampanya> Kampanya { get; set; }
    }
}