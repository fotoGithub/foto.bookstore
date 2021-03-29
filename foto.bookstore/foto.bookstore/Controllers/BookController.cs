using foto.bookstore.Models;
using foto.bookstore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foto.bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
            //return $"Book with id= {id} ";
        }
        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
            //return $"Book with name = {bookName} & author = {authorName}";
        }
    }
}
