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

        public string GetId(){ return Id; }

        public void SetId(string id) { this.Id = id; }

        public string GetTitle() { return Title; }

        public void SetTitle(string title) {  this.Title = title; }

        public string GetAuthor() { return Author; }

        public void SetAuthor(string author) {  this.Author = author; }
    }
}
