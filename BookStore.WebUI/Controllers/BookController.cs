using BookStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.WebUI.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        public int PageSize = 4;

        public BookController(IBookRepository bookRep)
        {
            repository = bookRep;
             
        }

        public ViewResult List(int pageno)
        {
            return View(repository.Books
                             .OrderBy(b=>b.ISBN)
                             .Skip((pageno-1)*PageSize)
                             .Take(PageSize)
                             );
        }

        public ViewResult ListAll()
        {
            return View(repository.Books);
        }
    }
}