namespace EstateSiteProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IlanDetayDb")]
    public partial class IlanDetayDb
    {
        [Key]
        public int detayId { get; set; }

        public int? odaSayisi { get; set; }

        public int? salonSayisi { get; set; }

        public int? metreKare { get; set; }

        public int? binaYasi { get; set; }

        public int? bulunduguKat { get; set; }

        public int? katSayisi { get; set; }

        public int? banyoSayisi { get; set; }

        [StringLength(50)]
        public string ısınmaTipi { get; set; }

        public bool? esyaDurumu { get; set; }

        [StringLength(500)]
        public string detayAciklama { get; set; }

        public int? ilanId { get; set; }

        public virtual ilan ilan { get; set; }
    }
}
