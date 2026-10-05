using AutoMapper.Execution;
using casestuady2.Data;
using casestuady2.GenaricRepo;
using casestuady2.Models;

namespace casestuady2.Unit
{
    public class UnitOfWork : IUnitOfWork
    {

        public IGenaricRepo<Category> Category { get;  set; }
        public IGenaricRepo<Book> Book { get;  set; }
        public IGenaricRepo<Customer> Customer { get;  set; }
        public IGenaricRepo<Borrowing> Borrowing { get;  set; }
        protected readonly AppDbContext appDbContext;

        public UnitOfWork(
               IGenaricRepo<Category> category,
               IGenaricRepo<Book> book,
               IGenaricRepo<Customer> customer,
               IGenaricRepo<Borrowing> borrowing,
               AppDbContext app
               )
        {
            Category = category;
            Book = book;
            Customer = customer;
            Borrowing = borrowing;
            appDbContext = app;
        }
        public void Save()
        {
            appDbContext.SaveChanges();
        }
    }
}
