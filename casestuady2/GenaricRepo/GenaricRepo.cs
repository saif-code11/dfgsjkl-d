
using casestuady2.Data;

namespace casestuady2.GenaricRepo
{
    public class GenaricRepo<T> : IGenaricRepo<T> where T : class
    {
       protected readonly AppDbContext _appDbContext;
        public GenaricRepo(AppDbContext appDb) 
        {
            _appDbContext = appDb;  
        }
        public void Add(T item)
        {
            _appDbContext.Set<T>().Add(item);
           
        }

        public void Delete(int id)
        {
            var d = _appDbContext.Set<T>().Find(id);
            if (d != null) { _appDbContext.Set<T>().Remove(d); }
        }

        public T Get(int id)
        {
            return  _appDbContext.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _appDbContext.Set<T>().ToList();
        }

        public void Update(T item)
        {
            _appDbContext.Set<T>().Update(item);
        }
    }
}
