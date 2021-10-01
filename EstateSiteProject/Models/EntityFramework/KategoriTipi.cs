namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KategoriTipi")]
    public partial class KategoriTipi
    {
        public int kategoriTipiId { get; set; }

        [StringLength(250)]
        [Display(Name = "Kategori Türü")]
        public string kategoriTipiAd { get; set; }

        public int? kategoriId { get; set; }

        public virtual Kategori Kategori { get; set; }
    }
}
