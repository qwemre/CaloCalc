using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class KategoriCFG : IEntityTypeConfiguration<Kategori>
    {
       

        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasData(
               new Kategori { KategoriID = 1, KategoriAdi = "Ana Yemekler" },
               new Kategori { KategoriID = 2, KategoriAdi = "Çorbalar" },
               new Kategori { KategoriID = 3, KategoriAdi = "Salatalar" },
               new Kategori { KategoriID = 4, KategoriAdi = "Tatlılar" },
               new Kategori { KategoriID = 5, KategoriAdi = "İçecekler" },
               new Kategori { KategoriID = 6, KategoriAdi = "Meyveler" },
               new Kategori { KategoriID = 7, KategoriAdi = "Abur Cubur" },
               new Kategori { KategoriID = 8, KategoriAdi = "Kahvaltılık" },
               new Kategori { KategoriID = 9, KategoriAdi = "Sebzeler" });
        }
    }
}
