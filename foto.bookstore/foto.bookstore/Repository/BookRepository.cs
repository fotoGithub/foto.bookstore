using foto.bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foto.bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSurce();
        }
        public BookModel GetBookById(int id)
        {
            return DataSurce().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSurce().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSurce()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Ajay"},
                new BookModel(){Id=2,Title="Java",Author="Priyanka"},
                new BookModel(){Id=3,Title="HTML",Author="Rajan"},
                new BookModel(){Id=4,Title="Angular",Author="Nikhil"},
                new BookModel(){Id=5,Title="C-sharp",Author="Arihhant"},
            };
        }
    }
}
