using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kullanici
    {
        public Kullanici()
        {
            Ogunler = new List<Ogun>();
        }
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciMail { get; set; }
        public string Sifre { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
        public int Yasi { get; set; }
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public int OgunID { get; set; }
        public virtual ICollection<Ogun> Ogunler { get; set; }
    }
}
