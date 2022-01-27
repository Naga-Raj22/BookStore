using BookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return dataSource();
        }

        public BookModel GetBookById(int bookId)
        {
            return dataSource().Where(x => x.Id == bookId).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string bookTitle, string bookAuthor)
        {
            return dataSource().Where(x => x.Title == bookTitle || x.Author == bookAuthor).ToList();
        }

        private List<BookModel> dataSource()
        {
            return new List<BookModel>()
          {
              new BookModel(){Id=1,Title="MVC",Author="Naga"},
              new BookModel(){Id=2,Title="C#",Author="Naga"},
              new BookModel(){Id=3,Title="PHP",Author="Bhagya"},
              new BookModel(){Id=4,Title="SQL",Author="Kiran"},
              new BookModel(){Id=5,Title="PHP",Author="Ravi"},
          };
        }
    }
}
