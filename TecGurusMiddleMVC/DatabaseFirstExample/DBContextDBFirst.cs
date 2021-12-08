using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TecGurusMiddleMVC.DatabaseFirstExample
{
    public partial class DBContextDBFirst : DbContext
    {
        public DBContextDBFirst()
            : base("name=ConnectionDatabaseFirst")      // DBContextDBFirst
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<SellersXBrand> SellersXBrands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasMany(e => e.SellersXBrands)
                .WithOptional(e => e.Brand)
                .HasForeignKey(e => e.IDBrand);

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.SellersXBrands)
                .WithRequired(e => e.Seller)
                .HasForeignKey(e => e.IDSeller)
                .WillCascadeOnDelete(false);
        }
    }
}
