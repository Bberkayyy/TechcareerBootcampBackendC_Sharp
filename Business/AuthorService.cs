using Bootcamp_Day4_BookProject.Data;
using Bootcamp_Day4_BookProject.Exceptions;
using Bootcamp_Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Business;

public class AuthorService : IAuthorService
{

    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    /// <summary>
    /// Parametre olarak verilen yazarı veri tabanına(projede liste) ekler.
    /// </summary>
    /// <param name="author">Yazar</param>
    public void Add(Author author)
    {
        try
        {
            AddRules(author);
            _authorRepository.Add(author);
            GetList();

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }

    /// <summary>
    /// Parametre olarak verilen id'ye karşılık gelen yazarı veritabanından(listeden) siler.
    /// </summary>
    /// <param name="id">Id</param>
    public void Delete(int id)
    {
        try
        {

            _authorRepository.Delete(id);
            GetList();

        }
        catch (AuthorNotFoundException e)
        {

            Console.WriteLine(e.Message);
        }
    }

    /// <summary>
    /// Parametre olarak verilen id'ye karşılık gelen yazar ekrana yazdırır.
    /// </summary>
    /// <param name="id">Id</param>
    public void GetById(int id)
    {
        try
        {
            Author? author = _authorRepository.GetById(id);
            Console.WriteLine(author);
        }
        catch (AuthorNotFoundException e)
        {

            Console.WriteLine(e.Message);
        }
    }

    /// <summary>
    /// Yazarlar listesini ekrana yazdırır.
    /// </summary>
    public void GetList()
    {
        List<Author> authors = _authorRepository.GetAll();
        authors.ForEach(author => Console.WriteLine(author));
    }

    /// <summary>
    /// Yazar ekleme kuralları 
    /// </summary>
    /// <param name="author">Yazar</param>
    /// <exception cref="AuthorNameException">Girilen yazar ismi 3'ten küçük olmamalıdır.</exception>
    private void AddRules(Author author)
    {
        if (author.Name.Length < 3)
        {
            throw new AuthorNameException(author.Name);
        }

    }

}
