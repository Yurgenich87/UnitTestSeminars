using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar4
{
    public class Book
    {
        public string Id;
        public string Title;
        public string Author;

        public Book(string id)
        {
            this.Id = id;
        }

        public Book(string id, string title, string author) 
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;

        }
        // Метод возвращает текущее значение идентификатора книги
        public string GetId(){ return Id; }

        // Метод устанавливает новое значение идентификатора книги
        public void SetId(string id) { this.Id = id; }

        //Метод возвращает текущее значение заголовка книги
        public string GetTitle() { return Title; }
        
        // Метод устанавливает новое значение заголовка книги
        public void SetTitle(string title) {  this.Title = title; }
        // Метод возвращает текущее значение автора книги
        public string GetAuthor() { return Author; }
        // Метод устанавливает новое значение автора книги
        public void SetAuthor(string author) {  this.Author = author; }
    }
}
