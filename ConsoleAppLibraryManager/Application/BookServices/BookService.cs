using ConsoleAppLibraryManager.Entities.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLibraryManager.Application.BookServices
{
    internal class BookService
    {
        private List<Book> _books;

        public BookService(List<Book> booksList)
        {
            _books = booksList;
        }

        public void ShowAllBooks()
        {
            StringBuilder sb = new StringBuilder();

            if(_books.Count() < 1)
            {
                Console.WriteLine("");
                Console.WriteLine("There no books registred!");
                Console.WriteLine("");
                return;
            }

            foreach (var book in _books)
            {
                Console.WriteLine($"ID: {book.Id} | Title: {book.Title} | Author: {book.Author} | Year: {book.ReleaseDate}");
            }

            Console.WriteLine();
        }

        public void ShowBookById()
        {
            Console.WriteLine("Enter the ID of the book to search:");
            var id = Console.ReadLine();

            var book = _books.FirstOrDefault(b => b.Id == Guid.Parse(id));

            if(book is null)
                Console.WriteLine("Book not found.");

            Console.Write($"ID: {book.Id} | Title: {book.Title} | Author: {book.Author} | Year: {book.ReleaseDate}");
        }

        public void RemoveBook(List<Book> booksMemory)
        {
            string id;

            Console.WriteLine("Enter the ID of the book to delete:");

            id = Console.ReadLine();
            
            if(string.IsNullOrEmpty(id))
                id = Utils.FieldEmptyValidation.FieldValidation("ID", "book");

            var book = booksMemory.FirstOrDefault(x => x.Id == Guid.Parse(id));

            if(book is null)
            {
                Console.WriteLine("Book not found.");
                Console.WriteLine("");
                return;
            }

            booksMemory.Remove(book);

            Console.WriteLine("Book deleted.");
            Console.WriteLine("");
        }

        public Book AddBook()
        {
            string title;
            string author;
            string isbn;

            Console.WriteLine("Enter book title:");
            
            title = Console.ReadLine()!;

            while(string.IsNullOrEmpty(title))
                title = Utils.FieldEmptyValidation.FieldValidation("Title", "book");

            Console.WriteLine("Enter book author:");
            author = Console.ReadLine()!;

            while(string.IsNullOrEmpty(author))
                author = Utils.FieldEmptyValidation.FieldValidation("Author", "book");

            Console.WriteLine("Enter book ISBN:");
            isbn = Console.ReadLine()!;

            while(string.IsNullOrEmpty(isbn))
                isbn = Utils.FieldEmptyValidation.FieldValidation("ISBN", "book");

            Console.WriteLine("Enter book release date (yyyy-mm-dd):");
            DateTime releaseDate;

            while(!DateTime.TryParse(Console.ReadLine()!, out releaseDate))
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-mm-dd format:");
            }

            return new Book(title, author, isbn, releaseDate);
        }
    }
}
