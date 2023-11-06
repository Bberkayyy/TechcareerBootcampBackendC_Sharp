using Bootcamp_Day4_BookProject.Data;
using Bootcamp_Day4_BookProject.Exceptions;
using Bootcamp_Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Business;


//dependency injection (constructor args injection, sette injection, method injection)
//Addscopped, addsingleton,addtransient
public class BookService : IBookService
{

    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    /// <summary>
    /// Parametre olarak verilen kitabı veritabanına(projede liste) ekler
    /// </summary>
    /// <param name="book">Kitap</param>
    public void Add(Book book)
    {
        //Validasyondan geçemeyen kitabı listeye eklemeyeceğiz.
        try
        {
            AddRules(book);
            _bookRepository.Add(book);
            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    /// <summary>
    /// Parametre olarak verilen id'ye karşılık gelen kitabı veritabanından(listeden) siler.
    /// </summary>
    /// <param name="id">Id</param>
    public void Delete(int id)
    {

        try
        {
            _bookRepository.Delete(id);

            GetList();
        }
        catch (BookNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }

    }

    /// <summary>
    /// Parametre olarak verilen id'ye karşılık gelen kitabı ekrana yazdırır.
    /// </summary>
    /// <param name="id">Id</param>
    public void GetById(int id)
    {
        try
        {
            Book? book = _bookRepository.GetById(id);
            Console.WriteLine(book);

        }
        catch (BookNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }

    }

    /// <summary>
    /// Parametre olarak verilen isbn'e karşılık gelen kitabı ekrana yazdırır.
    /// </summary>
    /// <param name="isbn"></param>
    public void GetByIsbn(string isbn)
    {
        try
        {
            Book? book = _bookRepository.GetByIsbn(isbn);
            Console.WriteLine(book);
        }
        catch (BookNotFoundWithIsbnException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    /// <summary>
    /// Kitap listesini ekrana yazdırır.
    /// </summary>
    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }

    /// <summary>
    /// Kitap ekleme kuralları
    /// </summary>
    /// <param name="book">Kitap</param>
    /// <exception cref="BookTitleException">BookTitle 3'den küçük olamaz</exception>
    /// <exception cref="BookPriceAndStockException">BookPrice veya BookStock 0'dan küçük olamaz</exception>
    private void AddRules(Book book)
    {
        //Ekleme işi yaparken kitap başlığı min 2 karater olmalıdır.
        //Price ve stock propları - değer alamaz.
        if (book.Title.Length <= 2)
        {
            throw new BookTitleException(book.Title);
        }
        if (book.Price < 0 || book.Stock < 0)
        {
            throw new BookPriceAndStockException(book.Price, book.Stock);
        }
    }
}
