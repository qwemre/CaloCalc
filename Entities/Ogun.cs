﻿using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ogun
    {

        public Ogun()
        {
            Yiyecekler = new List<Yiyecek>();
        }
        [Key]
        public int OgunID { get; set; }
        public Ogunler OgunAdi { get; set; }
        public DateTime YemekYemeZamani { get; set; }
        public double PorsiyonAdet { get; set; }
        public double ToplamKalori { get; set; }
        public int KullaniciID { get; set; }
        //bire çok yaptık değişebilir 
        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<Yiyecek> Yiyecekler { get; set; }  
        

    }
}
