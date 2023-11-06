using Bootcamp_Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Business;

public interface IAuthorService
{
    void GetList();
    void Add(Author author);
    void Delete(int id);
    void GetById(int id);
}
