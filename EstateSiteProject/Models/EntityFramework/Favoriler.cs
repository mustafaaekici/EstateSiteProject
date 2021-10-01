namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Favoriler")]
    public partial class Favoriler
    {
        [Key]
        public int FavId { get; set; }

        public int? ilanId { get; set; }

        [StringLength(100)]
        [Display(Name = "Favori Adý")]
        public string FavAd { get; set; }

        public int? loginId { get; set; }

        public virtual ilan ilan { get; set; }

        public virtual Login Login { get; set; }
    }
}
