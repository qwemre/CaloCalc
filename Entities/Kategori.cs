namespace Entities
{
    public class Kategori
    {
        public Kategori()
        {
            Yiyecekler = new List<Yiyecek>();
        }
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public virtual ICollection<Yiyecek> Yiyecekler { get; set; }
    }
}