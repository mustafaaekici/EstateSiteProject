namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kampanya")]
    public partial class Kampanya
    {
        public int kampanyaId { get; set; }

        [StringLength(250)]
        [Display(Name = "Kampanya Adý")]
        public string kampanyaAd { get; set; }

        [StringLength(100)]
        [Display(Name = "Kampanya Resmi")]
        public string kampanyaResim { get; set; }
    }
}
