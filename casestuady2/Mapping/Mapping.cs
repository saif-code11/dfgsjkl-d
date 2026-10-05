using System.ComponentModel;
using AutoMapper;
using AutoMapper.Execution;
using casestuady2.Dtos;
using casestuady2.Models;

namespace casestuady2.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Customer, MemberDtos>();
            CreateMap<MemberCreateDtos , Customer>();

            CreateMap<Category, CategoryDtos>();
            CreateMap<CategoryCreate, Category>();


            CreateMap<Borrowing, BookingDtos>();
            CreateMap<BoojingCreateDto, Borrowing>();

            CreateMap<Book, BookDtos>();
            CreateMap<BookCreateDtos, Book>();
        }
    }
}
