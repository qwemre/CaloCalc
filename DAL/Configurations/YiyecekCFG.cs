using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class YiyecekCFG:IEntityTypeConfiguration<Yiyecek>
    {
       
        

        public void Configure(EntityTypeBuilder<Yiyecek> builder)
        {
           

            //builder.HasData(

                    //new Yiyecek
                    //{
                    //    YiyecekID = 1,
                    //    YiyecekAdi = "Kuru Fasulye",
                    //    Kalori = 300,
                    //    KategoriID = 1,
                    //    FotografYolu = "C:\\Users\\EmreK\\Desktop\\fasülye.jpg",
                    //    Fotograf = File.ReadAllBytes("C:\\Users\\EmreK\\Desktop\\fasülye.jpg")
                    //}

            //);
            builder.Property(e => e.Fotograf).HasColumnType("image");
            builder.Property(e => e.FotografYolu).HasMaxLength(255);


        }
    }
}
