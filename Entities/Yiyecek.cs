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
     
        [Key]
        public int YiyecekID { get; set; }
        public string YiyecekAdi { get; set; }
        public double Kalori { get; set; }
        //public int Porsiyon { get; set; }
        public byte[]? Fotograf { get; set; }
        public string? FotografYolu { get; set; }
        public int? OgunID { get; set; }
        public virtual Ogun Ogun { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }

       


    }
}
