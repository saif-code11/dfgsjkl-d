using casestuady2.GenaricRepo;
using casestuady2.Models;

namespace casestuady2.Repo
{
    public interface IBook : IGenaricRepo<Book>
    {
        List<Book> GetBooks();
    }
}
