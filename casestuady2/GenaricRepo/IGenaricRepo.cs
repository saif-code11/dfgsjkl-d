namespace casestuady2.GenaricRepo
{
    public interface IGenaricRepo<T> where T : class
    {
        T Get(int id);
        List<T> GetList();

        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
}
