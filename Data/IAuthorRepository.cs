using Bootcamp_Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Data;

public interface IAuthorRepository : IEntityBaseRepository<Author,int>
{

}
