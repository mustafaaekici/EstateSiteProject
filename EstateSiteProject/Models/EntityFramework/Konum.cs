namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Konum")]
    public partial class Konum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Konum()
        {
            ilans = new HashSet<ilan>();
        }

        public int konumId { get; set; }

        [StringLength(250)]
        [Display(Name = "Semt / Mahalle Adý")]
        public string konumAd { get; set; }

        [StringLength(20)]
        [Display(Name = "Þehir")]
        public string ilAdi { get; set; }

        [StringLength(20)]
        [Display(Name = "Ýlçe")]
        public string ilceAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilan> ilans { get; set; }
    }
}
