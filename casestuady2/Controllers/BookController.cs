using AutoMapper;
using casestuady2.Dtos;
using casestuady2.Models;
using casestuady2.Unit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace casestuady2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        protected readonly IUnitOfWork unitOfWork;
        protected readonly IMapper mapper;

        public BookController(IMapper m , IUnitOfWork unitOf)
        {
            mapper = m;
            unitOfWork = unitOf;
        }


        [HttpPost]
        public IActionResult Create(BookCreateDtos book)
        {
            var c = unitOfWork.Category.Get(book.CategoryId);
            if (c == null) return NotFound("No Category");

            var isbn = unitOfWork.Book.GetList().Where(f => f.ISBN == book.ISBN).FirstOrDefault();

            if (isbn != null) return BadRequest();

            var r = mapper.Map<Book>(book);
            unitOfWork.Book.Add(r);
            unitOfWork.Save();

            return Created();
        }

        [HttpGet]
        public IActionResult GetAll(string name)
        {
            var data = unitOfWork.Book.GetList()
                .Where(d => d.Author.Contains(name))
                .Select(e => new 
                {
                    Id = e.Id,
                    Title = e.Title,
                    Author = e.Author,
                    Price = e.Price,

                }).ToList();


            data.OrderBy(t => t.Title).ToList();

            return Ok(data);
        }
    }
}
