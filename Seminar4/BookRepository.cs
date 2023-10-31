using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar4
{
    public interface BookRepository
    {
        Book FindById(string id);

        List<Book> FindAll();
    }
}
