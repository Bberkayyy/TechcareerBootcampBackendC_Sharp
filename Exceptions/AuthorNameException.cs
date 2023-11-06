using Bootcamp_Day4_BookProject.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Exceptions
{
    public class AuthorNameException : Exception
    {
        public AuthorNameException(string name):base(Messages.AuthorNameExceptionMessage(name))
        {
            
        }
    }
}
