using Bootcamp_Day4_BookProject.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Exceptions
{
    internal class BookNotFoundWithIsbnException :Exception
    {
        public BookNotFoundWithIsbnException(string isbn) : base (Messages.BookNotFoundWithIsbnExceptionMessage(isbn))
        {
            
        }
    }
}
