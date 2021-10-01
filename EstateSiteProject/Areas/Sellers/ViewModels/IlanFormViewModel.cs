using EstateSiteProject.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateSiteProject.Areas.Sellers.ViewModels
{
    public class IlanFormViewModel
    {
        public IEnumerable<Kategori> Kategoris { get; set; }
        public IEnumerable<SatisTipi> SatisTipis { get; set; }
        public IEnumerable<Konum> Konums { get; set; }
        public IEnumerable<IlanDetay> IlanDetays { get; set; }
        public ilan ilan { get; set; }
    }
}