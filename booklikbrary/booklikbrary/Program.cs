using booklibraryBL;

namespace BookLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME LIBRARY SYSTEM");

            Book top1Book = new Book(); //
            top1Book.title = "The Alchemist";
            top1Book.author = "Paulo Coelho";
            top1Book.publisher = "some publisher";
            top1Book.releaseDate = new DateTime(1988, 1, 1);
            top1Book.ISBN = "BOOK1231231";

            Book top2Book = new Book
            {
                title = "Harry Potter and the Philosopher\'s Stone",
                author = "J.K. Rowling",
                publisher = "some publisher",
                releaseDate = new DateTime(1997, 1, 1),
                ISBN = "BOOK456456"
            };

            Library pupLibrary = new Library { name = "PUP LIBRARY" };

            pupLibrary.AddBook(top1Book);
            pupLibrary.AddBook(top2Book);

            DisplayBook(pupLibrary.books);

            Console.WriteLine("Search book to delete by author:");

            pupLibrary.DeleteBook(top1Book);

            Console.WriteLine("---------");
            DisplayBook(pupLibrary.books);

        }

        static void DisplayBook(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Book: {book.title}");
            }
        }

    }
}