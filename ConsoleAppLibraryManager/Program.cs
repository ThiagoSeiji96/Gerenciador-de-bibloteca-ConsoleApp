// See https://aka.ms/new-console-template for more information

using ConsoleAppLibraryManager.Application.BookServices;
using ConsoleAppLibraryManager.Entities.Book;
using ConsoleAppLibraryManager.Entities.Borrow;

List<Borrow> borrowsMemory;
List<Book> booksMemory = new List<Book>();


string optionSelected = string.Empty;

bool showLoopOptions = false;

Console.WriteLine("Hello! Please choose an option below:");

Console.WriteLine("1. Create book");
Console.WriteLine("2. Get all books");
Console.WriteLine("3. Get book by ID");
Console.WriteLine("4. Delete book");

optionSelected = Console.ReadLine();
while (optionSelected != "0")
{
	Thread.Sleep(1800);
	if (showLoopOptions)
	{
		Console.WriteLine("Pick a option:");

		Console.WriteLine("1. Create book");
		Console.WriteLine("2. Get all books");
		Console.WriteLine("3. Get book by ID");
		Console.WriteLine("4. Delete book");

		optionSelected = Console.ReadLine();
	}

	showLoopOptions = true;

	switch (optionSelected)
	{
		case "1":
			BookService bookServiceCreate = new BookService(booksMemory);
			booksMemory.Add(bookServiceCreate.AddBook());
			break;

		case "2":
			BookService bookServiceShowAll = new BookService(booksMemory);
			bookServiceShowAll.ShowAllBooks();
			break;

		case "3":
			BookService bookServiceGetById = new BookService(booksMemory);
			bookServiceGetById.ShowBookById();
			break;

		case "4":
			BookService bookServiceDelete = new BookService(booksMemory);
			bookServiceDelete.RemoveBook(booksMemory);
			break;

		default:
			break;
	}
}