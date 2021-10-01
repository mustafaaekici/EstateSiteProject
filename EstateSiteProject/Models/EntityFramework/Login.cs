namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Login()
        {
            Favorilers = new HashSet<Favoriler>();
            ilans = new HashSet<ilan>();
        }

        public int loginId { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Kullanýcý Adý")]
        public string loginAd { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Kullanýcý Soyadý")]
        public string loginSoyad { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Email Adresi")]
        public string loginEmail { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Kullanýcý Þifre")]
        public string loginSifre { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Kullanýcý Rol")]
        public string Rol { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Telefon No")]
        public string telefonNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favoriler> Favorilers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilan> ilans { get; set; }
    }
}
