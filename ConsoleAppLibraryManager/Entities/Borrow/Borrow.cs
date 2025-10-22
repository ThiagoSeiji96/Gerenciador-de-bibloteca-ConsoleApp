using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLibraryManager.Entities.Borrow
{
    internal class Borrow
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime StartBorrow { get; set; }
        public DateTime FinishBorrow { get; set; }
    }
}