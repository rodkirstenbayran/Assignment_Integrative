using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booklibraryBL
{
    public class Library
    {
        public string name;
        public string address;
        public List<Book> books = new List<Book>(); //instantiate new list of type Book

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book SearchBook(string author)
        {
            Book foundBook = new Book();

            foreach (Book libro in books)
            {
                if (libro.author.Contains(author))
                {
                    foundBook = libro;
                }
            }

            return foundBook;
        }

        public void DeleteBook(Book book)
        {
            books.Remove(book);
        }
    }
}