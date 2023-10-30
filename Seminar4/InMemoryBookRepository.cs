using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Seminar4;

namespace UnitTest.Seminar4
{
    public class InMemoryBookRepository : BookRepository
    {
        private readonly Dictionary<string, Book> books;

        public InMemoryBookRepository()
        {
            books = new Dictionary<string, Book>();
            books["1"] = new Book("1", "Book1", "Author1");
            books["2"] = new Book("2", "Book2", "Author2");
        }

        public Book FindById(string id)
        {
            return books.TryGetValue(id, out var book) ? book : null;
        }

        public List<Book> FindAll()
        {
            return new List<Book>(books.Values);
        }
    }
}
