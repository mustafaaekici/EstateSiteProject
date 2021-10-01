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
        [Display(Name = "Semt / Mahalle Ad�")]
        public string konumAd { get; set; }

        [StringLength(20)]
        [Display(Name = "�ehir")]
        public string ilAdi { get; set; }

        [StringLength(20)]
        [Display(Name = "�l�e")]
        public string ilceAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilan> ilans { get; set; }
    }
}
