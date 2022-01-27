using BookStoreApp.Models;
using BookStoreApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBookById(int bookId)
        {
            return _bookRepository.GetBookById(bookId);
        }

        public List<BookModel> SearchBook(string Title, string Author)
        {
            return _bookRepository.SearchBook(Title, Author);
        }
    }
}
