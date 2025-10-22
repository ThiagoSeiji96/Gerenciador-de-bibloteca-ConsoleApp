using ConsoleAppLibraryManager.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLibraryManager.Entities.Book
{
    internal class Book : BaseModel
    {
        public Book(string title, string author, string isbn, DateTime releaseDate)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            ISBN = isbn;
            ReleaseDate = releaseDate;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
