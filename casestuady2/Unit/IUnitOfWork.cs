using casestuady2.GenaricRepo;
using casestuady2.Models;

namespace casestuady2.Unit
{
    public interface IUnitOfWork
    {
        IGenaricRepo<Customer> Customer { get; }
        IGenaricRepo<Book> Book { get; }
        IGenaricRepo<Borrowing> Borrowing { get; }
        IGenaricRepo<Category> Category { get; }
        void Save();
    }
}
