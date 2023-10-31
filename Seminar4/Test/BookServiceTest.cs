using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTest.Seminar4;

namespace UnitTest.Seminar4.Test
{
    [TestClass]
    [TestClass]
    public class BookServiceTest
    {
        [TestMethod]
        public void FindBookByIdTest()
        {
            // Создаем мок-объект BookRepository
            var bookRepositoryMock = new Mock<BookRepository>();

            // Создаем экземпляр BookService, передавая мок-объект BookRepository
            BookService bookService = new BookService(bookRepositoryMock.Object);

            // Устанавливаем ожидаемое поведение мок-объекта при вызове метода FindById с аргументом "1"
            bookRepositoryMock.Setup(repo => repo.FindById("1"))
                .Returns(new Book("1", "Book1", "Author1"));

            // Вызываем метод FindBookById с аргументом "1"
            Book book = bookService.FindBookById("1");

            // Проверяем результаты
            Assert.IsNotNull(book); // Убеждаемся, что объект Book не является null
            Assert.AreEqual("1", book.Id); // Проверяем, что свойство Id равно "1"
            Assert.AreEqual("Book1", book.Title); // Проверяем, что свойство Title равно "Book1"
            Assert.AreEqual("Author1", book.Author); // Проверяем, что свойство Author равно "Author1"
        }
    }


}
