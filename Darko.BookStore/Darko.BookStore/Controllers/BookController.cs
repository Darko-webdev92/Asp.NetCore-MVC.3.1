using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Darko.BookStore.Models;
using Darko.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Darko.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
      public ViewResult GetAllBooks()
       //  public List<BookModel> GetAllBooks()
        {
            // return "All books";
         //  return  _bookRepository.GetAllBooks();
         var data = _bookRepository.GetAllBooks();
             return View();
        }

        public BookModel GetBook(int id)
        {
            //  return "book with id " + id;
            return _bookRepository.GetBookById(id);
        }


        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            // return $"Book with name = {bookName} & author {authorName}";
            return _bookRepository.SearchBook(bookName, authorName);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
