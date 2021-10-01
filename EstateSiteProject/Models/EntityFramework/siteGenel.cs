namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("siteGenel")]
    public partial class siteGenel
    {
        public int siteGenelId { get; set; }

        [StringLength(250)]
        [Display(Name = "Site Adý")]
        public string siteGenelAd { get; set; }

        [StringLength(50)]
        [Display(Name = "Telefon No")]
        public string sirketTelNo { get; set; }

        [StringLength(250)]
        [Display(Name = "Adres")]
        public string sirketAdres { get; set; }

        [StringLength(250)]
        [Display(Name = "Instagram")]
        public string sirketInstagram { get; set; }

        [StringLength(250)]
        [Display(Name = "Facebook")]
        public string sirketFacebook { get; set; }
    }
}
