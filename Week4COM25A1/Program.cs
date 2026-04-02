// See https://aka.ms/new-console-template for more information

//List<int> numbers = new List<int>([2,4,6,7,8]);

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}

using Week4COM25A1;

Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
Book book3 = new Book("1984", "George Orwell");


List<Book> booksIntheLibrary = new List<Book>([book1,book2,book3]);

foreach (Book book in booksIntheLibrary)
{
    Console.WriteLine(book.Title);
}
