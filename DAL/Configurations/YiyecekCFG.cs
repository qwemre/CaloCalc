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
    internal class YiyecekCFG:IEntityTypeConfiguration<Yiyecek>
    {
       

        public void Configure(EntityTypeBuilder<Yiyecek> builder)
        {
            builder.HasData(
                new Yiyecek { YiyecekID = 1, YiyecekAdi = "Kuru Fasulye", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 2, YiyecekAdi = "Pilav", Kalori = 200, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 3, YiyecekAdi = "Adana Kebap", Kalori = 400, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 4, YiyecekAdi = "Fırında Tavuk", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 5, YiyecekAdi = "İzmir Köfte", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 6, YiyecekAdi = "Köri Soslu Tavuk", Kalori = 500, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 7, YiyecekAdi = "Mantar Sote", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 8, YiyecekAdi = "Patates Kızartması", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 9, YiyecekAdi = "Karnıbahar Kızartması", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 10, YiyecekAdi = "Karnıbahar Haşlaması", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 11, YiyecekAdi = "Brokoli Haşlaması", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 12, YiyecekAdi = "Tas Kebabı", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 13, YiyecekAdi = "Sebzeli Misket Köfte", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 14, YiyecekAdi = "Tepsi Kebabı", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 15, YiyecekAdi = "Salçalı Makarna", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 16, YiyecekAdi = "Köri Sosluı Makarna", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 17, YiyecekAdi = "Patatesli Sulu Köfte", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 18, YiyecekAdi = "Kuru Patlıcan Dolması", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 19, YiyecekAdi = "Biber Dolması", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 20, YiyecekAdi = "Çökertme Kebabı", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 21, YiyecekAdi = "Patlıcan Yemeği", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 22, YiyecekAdi = "Taco", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 23, YiyecekAdi = "Sigara Böreği", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 24, YiyecekAdi = "Kıymalı Börek", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 25, YiyecekAdi = "Peynirli Börek", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 1 },
                new Yiyecek { YiyecekID = 26, YiyecekAdi = "Ezogelin Çorbası", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 2 },
                new Yiyecek { YiyecekID = 27, YiyecekAdi = "Mercimek Çorbası", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 2 },
                new Yiyecek { YiyecekID = 28, YiyecekAdi = "Domates Çorbası", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 2 },
                new Yiyecek { YiyecekID = 29, YiyecekAdi = "Köfteli Erişte Çorbası", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 2 },
                new Yiyecek { YiyecekID = 30, YiyecekAdi = "Yayla Çorbası", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 2 },
                new Yiyecek { YiyecekID = 31, YiyecekAdi = "Brokoli Çorbası", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 2 },
                new Yiyecek { YiyecekID = 32, YiyecekAdi = "Mevsim Salata", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 3 },
                new Yiyecek { YiyecekID = 33, YiyecekAdi = "Çoban Salata", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 3 },
                new Yiyecek { YiyecekID = 34, YiyecekAdi = "Semizotu Salatası", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 3 },
                new Yiyecek { YiyecekID = 35, YiyecekAdi = "Revani", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 36, YiyecekAdi = "Mozaik Pasta", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 37, YiyecekAdi = "Şekerpare", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 38, YiyecekAdi = "Un Helvası", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 39, YiyecekAdi = "Triliçe", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 40, YiyecekAdi = "Brownie", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 41, YiyecekAdi = "Magnolia", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 42, YiyecekAdi = "Şöbiyet", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 43, YiyecekAdi = "Baklava", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 4 },
                new Yiyecek { YiyecekID = 44, YiyecekAdi = "Kola", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.ml, KategoriID = 5 },
                new Yiyecek { YiyecekID = 45, YiyecekAdi = "Fanta", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.ml, KategoriID = 5 },
                new Yiyecek { YiyecekID = 46, YiyecekAdi = "Ayran", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.ml, KategoriID = 5 },
                new Yiyecek { YiyecekID = 47, YiyecekAdi = "Soda", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.ml, KategoriID = 5 },
                new Yiyecek { YiyecekID = 48, YiyecekAdi = "Şalgam", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.ml, KategoriID = 5 },
                new Yiyecek { YiyecekID = 49, YiyecekAdi = "Su", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.ml, KategoriID = 5 },
                new Yiyecek { YiyecekID = 50, YiyecekAdi = "Elma", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 6 },
                new Yiyecek { YiyecekID = 51, YiyecekAdi = "Armut", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 6 },
                new Yiyecek { YiyecekID = 52, YiyecekAdi = "Muz", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 6 },
                new Yiyecek { YiyecekID = 53, YiyecekAdi = "Çilek", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 6 },
                new Yiyecek { YiyecekID = 54, YiyecekAdi = "Kivi", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 6 },
                new Yiyecek { YiyecekID = 55, YiyecekAdi = "Böğürtlen", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 6 },
                new Yiyecek { YiyecekID = 56, YiyecekAdi = "Mango", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 6 },
                new Yiyecek { YiyecekID = 57, YiyecekAdi = "Karpuz", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.dilim, KategoriID = 6 },
                new Yiyecek { YiyecekID = 58, YiyecekAdi = "Kavun", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.dilim, KategoriID = 6 },
                new Yiyecek { YiyecekID = 59, YiyecekAdi = "Cips", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 7 },
                new Yiyecek { YiyecekID = 60, YiyecekAdi = "Bisküvi", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 7 },
                new Yiyecek { YiyecekID = 61, YiyecekAdi = "Gofret", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 7 },
                new Yiyecek { YiyecekID = 62, YiyecekAdi = "Çikolata", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 7 },
                new Yiyecek { YiyecekID = 63, YiyecekAdi = "Jelibon", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 7 },
                new Yiyecek { YiyecekID = 64, YiyecekAdi = "Süzme Peynir", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.dilim, KategoriID = 8 },
                new Yiyecek { YiyecekID = 65, YiyecekAdi = "Siyah Zeytin", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 8 },
                new Yiyecek { YiyecekID = 66, YiyecekAdi = "Çilek Reçeli", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 8 },
                new Yiyecek { YiyecekID = 67, YiyecekAdi = "Yeşil Zeytin", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 8 },
                new Yiyecek { YiyecekID = 68, YiyecekAdi = "Salam", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 8 },
                new Yiyecek { YiyecekID = 69, YiyecekAdi = "Sosis", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 8 },
                new Yiyecek { YiyecekID = 70, YiyecekAdi = "Tereyağ", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 8 },
                new Yiyecek { YiyecekID = 71, YiyecekAdi = "Tam Yağlı Peynir", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 8 },
                new Yiyecek { YiyecekID = 72, YiyecekAdi = "Yumurta", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 8 },
                new Yiyecek { YiyecekID = 73, YiyecekAdi = "Domates", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 9 },
                new Yiyecek { YiyecekID = 74, YiyecekAdi = "Salatalık", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.adet, KategoriID = 9 },
                new Yiyecek { YiyecekID = 75, YiyecekAdi = "Roka", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 9 },
                new Yiyecek { YiyecekID = 76, YiyecekAdi = "Maydanoz", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 9 },
                new Yiyecek { YiyecekID = 77, YiyecekAdi = "Tere", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 9 },
                new Yiyecek { YiyecekID = 78, YiyecekAdi = "Marul", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 9 },
                new Yiyecek { YiyecekID = 79, YiyecekAdi = "Turp", Kalori = 300, Porsiyon = Entities.Enums.Porsiyonlar.gram, KategoriID = 9 }

            );
        }
    }
}
