using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLibraryManager.Entities.BaseEntity
{
    internal abstract class BaseModel
    {
        public Guid Id { get; set; }
    }
}
