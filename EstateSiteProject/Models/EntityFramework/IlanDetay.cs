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
        [Display(Name = "Oda Say�s�")]
        public int? odaSayisi { get; set; }

        [Display(Name = "Kat Say�s�")]
        public int? katSayisi { get; set; }

        [Display(Name = "Bina Ya��")]
        public int? binaYasi { get; set; }

        [Display(Name = "Bulundu�u Kat")]
        public int? bulunduguKat { get; set; }

        [Display(Name = "Salon Say�s�")]
        public int? salonSayisi { get; set; }

        [Display(Name = "Banyo Say�s�")]
        public int? banyoSayisi { get; set; }

        [StringLength(50)]
        [Display(Name = "Is�nma T�r�")]
        public string isinmaTipi { get; set; }

        [Display(Name = "E�ya Durumu")]
        public bool? esyaDurumu { get; set; }

        [StringLength(1000)]
        [Display(Name = "�lan Detayl� A��klama")]
        public string detayAciklama { get; set; }

        [Display(Name = "Metrekare")]
        public int? metreKare { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilan> ilans { get; set; }
    }
}
