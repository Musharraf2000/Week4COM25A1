using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4COM25A1
{
    internal class Student
    {
        private string name;
        private int age;
        private List<Book> booklist;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            booklist = new List<Book>();
        }

        public void AddBook()
        {
            Console.WriteLine("Enter Book Title :");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Author Name : ");
            string author = Console.ReadLine();
            Book b1 = new Book(title, author);
            booklist.Add(b1);
        }








        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal List<Book> Booklist { get => booklist; set => booklist = value; }
    }
}
