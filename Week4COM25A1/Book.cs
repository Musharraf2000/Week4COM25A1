using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4COM25A1
{
    internal class Book
    {
        private string title;
        private string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
    }
}
