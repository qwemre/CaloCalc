using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Yiyecek
    {
        public Yiyecek()
        {
            Ogunler = new List<Ogun>();
        }
        [Key]
        public int YiyecekID { get; set; }
        public string YiyecekAdi { get; set; }
        public double Kalori { get; set; }
        public Porsiyonlar Porsiyon { get; set; }
        public int KategoriID { get; set; }

        //Bunlar yapılacak

        public byte[]? Photo { get; set; }
        public string? PhotoPath { get; set; }

        //entity.Property(e => e.Photo).HasColumnType("image");
        //entity.Property(e => e.PhotoPath).HasMaxLength(255);

        public int OgunID { get; set; }
        public virtual ICollection<Ogun> Ogunler { get; set; }
        public Kategori Kategori { get; set; }
    }
}
