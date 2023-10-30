using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Seminar4;

namespace UnitTest.Seminar4
{
    //  Класс BookService представляет сервис для работы с книгами.
    public class BookService
    {
        private BookRepository bookRepository;

        // Конструктор.
        public BookService(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        // Метод выполняет поиск книги по её идентификаторуметод выполняет поиск книги по её идентификатору.
        public Book FindBookById(string id)
        {
            return bookRepository.FindById(id);
        }
        // Метод возвращает список всех доступных книг.
        public List<Book> FindAllBooks()
        {
            return bookRepository.FindAll();
        }
    }
}
