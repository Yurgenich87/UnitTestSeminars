using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Seminar4;

namespace UnitTest.Seminar4
{
    public class BookService
    {
        private BookRepository bookRepository;

        public BookService(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book FindBookById(string id)
        {
            return bookRepository.FindById(id);
        }

        public List<Book> FindAllBooks()
        {
            return bookRepository.FindAll();
        }
    }
}
