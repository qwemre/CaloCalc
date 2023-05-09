namespace BLL
{
    public interface ICRUD<T> where T : class
    {
        public bool Ekle(T entity); 

        public bool Guncelle(T entity);
        public bool Sil(int id);
        public List<T> Liste();

        public T Ara(int id);
    }
}