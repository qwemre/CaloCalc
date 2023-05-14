using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Yiyecek
    {
        public Yiyecek()
        {

        }
        [Key]
        public int YiyecekID { get; set; }
        public string YiyecekAdi { get; set; }
        public double Kalori { get; set; }        
        public int? Toplam { get; set; }
        public byte[]? Fotograf { get; set; }
        public string? FotografYolu { get; set; }
        [NotMapped]
        public string YiyeceKalori { get => YiyecekAdi + " " + Kalori +" Kalori" ; }
        public int? OgunID { get; set; }
        public virtual Ogun Ogun { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }

        public Yiyecek(string yiyecekAdi, int toplam, int kalori, int ogunValue)
        {
            Ogun = new Ogun();
            YiyecekAdi = yiyecekAdi;
            Toplam = toplam;
            Kalori = kalori;
            switch (ogunValue)
            {
                case 1:
                    Ogun.OgunAdi = Ogunler.Kahvaltı;
                    break;
                case 2:
                    Ogun.OgunAdi = Ogunler.SabahAtistirmasi;
                    break;
                case 3:
                    Ogun.OgunAdi = Ogunler.OglenYemegi;
                    break;
                case 4:
                    Ogun.OgunAdi = Ogunler.OglenAtistirmasi;
                    break;
                case 5:
                    Ogun.OgunAdi = Ogunler.AksamYemegi;
                    break;
                case 6:
                    Ogun.OgunAdi = Ogunler.AksamAtistirmasi;
                    break;             
            }

        }
    }
}
