using Bootcamp_Day4_BookProject.Models;


namespace Bootcamp_Day4_BookProject.Data;

public interface IBookRepository : IEntityBaseRepository<Book,int>
{
    Book GetByIsbn(string isbn);  
}
