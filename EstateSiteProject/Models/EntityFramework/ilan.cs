namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ilan")]
    public partial class ilan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ilan()
        {
            Favorilers = new HashSet<Favoriler>();
        }

        public int ilanId { get; set; }

        [StringLength(250)]
        [Display(Name = "Ýlan Baþlýk")]
        public string ilanBaslik { get; set; }

        [Display(Name = "Ýlan Fiyatý")]
        public decimal? ilanFiyat { get; set; }

        [Display(Name = "Ýlan Tarihi")]
        public DateTime? ilanTarih { get; set; }

        [StringLength(250)]
        [Display(Name = "Ýlan Resmi")]
        public string ilanResim { get; set; }

        [StringLength(1000)]
        [Display(Name = "Ýlan Açýklamasý")]
        public string ilanAciklama { get; set; }

        public int? KategoriId { get; set; }

        public int? satisTipiId { get; set; }

        public int? loginId { get; set; }

        public int? konumId { get; set; }

        public int? DetayId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favoriler> Favorilers { get; set; }

        public virtual IlanDetay IlanDetay { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Konum Konum { get; set; }

        public virtual Login Login { get; set; }

        public virtual SatisTipi SatisTipi { get; set; }
    }
}
