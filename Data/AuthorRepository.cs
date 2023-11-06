using Bootcamp_Day4_BookProject.Exceptions;
using Bootcamp_Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Data;

public class AuthorRepository : IAuthorRepository
{
    private readonly List<Author> _authors;

    public AuthorRepository()
    {
        _authors = new List<Author>()
        {
            new Author() {Id = 1, Name="Maurice Leblanc"},
            new Author() {Id = 2, Name="John Verdon"},
            new Author() {Id = 3, Name="Agatha Christie"},
            new Author() {Id = 4, Name="Gazi Mustafa Kemal Atatürk"},
            new Author() {Id = 5, Name="Turgut Özakman"},
            new Author() {Id = 6, Name="İlber Ortaylı"},
            new Author() {Id = 7, Name="David D. Burns"},
            new Author() {Id = 8, Name="Engin Geçtan"},
            new Author() {Id = 9, Name="Erich Fromm"},

        };
    }

    public void Add(Author author)
    {
       _authors.Add(author);
    }

    public void Delete(int id)
    {
        Author? author=_authors.Where(x=>x.Id==id).SingleOrDefault();
        if (author is null)
        {
            throw new AuthorNotFoundException(id);
        }
        _authors.Remove(author);
    }

    public List<Author> GetAll()
    {
        return _authors;
    }

    public Author? GetById(int id)
    {
        Author? author = _authors.SingleOrDefault(x => x.Id == id);
        if (author == null)
        {
            throw new AuthorNotFoundException(id);
        }

        return author;
    }
}
