using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Kategori
    {
        public Kategori()
        {
            Yiyecekler = new List<Yiyecek>();
        }
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public int YiyecekID { get; set; }
        public virtual ICollection<Yiyecek> Yiyecekler { get; set; }
    }
}