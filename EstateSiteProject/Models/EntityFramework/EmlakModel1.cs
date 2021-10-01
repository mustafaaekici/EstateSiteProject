using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EstateSiteProject.Models.EntityFramework
{
    public partial class EmlakModel1 : DbContext
    {
        public EmlakModel1()
            : base("name=EmlakModel1")
        {
        }

        public virtual DbSet<Favoriler> Favorilers { get; set; }
        public virtual DbSet<IlanDetay> IlanDetays { get; set; }
        public virtual DbSet<ilan> ilans { get; set; }
        public virtual DbSet<Kampanya> Kampanyas { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<KategoriTipi> KategoriTipis { get; set; }
        public virtual DbSet<Konum> Konums { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<SatisTipi> SatisTipis { get; set; }
        public virtual DbSet<siteGenel> siteGenels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ilan>()
                .Property(e => e.ilanFiyat)
                .HasPrecision(18, 0);
        }
    }
}
