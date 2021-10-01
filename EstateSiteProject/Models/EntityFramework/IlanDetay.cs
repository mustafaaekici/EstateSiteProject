namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IlanDetay")]
    public partial class IlanDetay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IlanDetay()
        {
            ilans = new HashSet<ilan>();
        }

        [Key]
        public int DetayId { get; set; }
        [Display(Name = "Oda Sayýsý")]
        public int? odaSayisi { get; set; }

        [Display(Name = "Kat Sayýsý")]
        public int? katSayisi { get; set; }

        [Display(Name = "Bina Yaþý")]
        public int? binaYasi { get; set; }

        [Display(Name = "Bulunduðu Kat")]
        public int? bulunduguKat { get; set; }

        [Display(Name = "Salon Sayýsý")]
        public int? salonSayisi { get; set; }

        [Display(Name = "Banyo Sayýsý")]
        public int? banyoSayisi { get; set; }

        [StringLength(50)]
        [Display(Name = "Isýnma Türü")]
        public string isinmaTipi { get; set; }

        [Display(Name = "Eþya Durumu")]
        public bool? esyaDurumu { get; set; }

        [StringLength(1000)]
        [Display(Name = "Ýlan Detaylý Açýklama")]
        public string detayAciklama { get; set; }

        [Display(Name = "Metrekare")]
        public int? metreKare { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilan> ilans { get; set; }
    }
}
