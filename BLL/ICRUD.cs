namespace BLL
{
    public interface ICRUD<T> where T : class
    {
        public void Ekle(T entity);

        public void Guncelle(T entity);
        public void Sil(int id);
        public List<T> Liste();

        public T Ara(int id);
    }
}