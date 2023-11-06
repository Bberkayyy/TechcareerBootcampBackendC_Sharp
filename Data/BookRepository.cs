using Bootcamp_Day4_BookProject.Exceptions;
using Bootcamp_Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Data;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _bookData;

    public BookRepository()
    {

        //Seed Data
        _bookData = new List<Book>()
        {
            new Book{Id =1,CategoryID="A",AuthorID=1,Isbn="11111",
                Description="Maurice Leblanc'ın Arsène Lupin'in maceralarını anlatan ilk öykü koleksiyonudur.",
                Price=250,
                Stock=2500,
                Title="Kibar Hırsız" },
            new Book{Id =2,CategoryID="A",AuthorID=2,Isbn="22222",
                Description="John Verdon'un 2010 yılında yayınlanan ilk romanıdır.",
                Price=120,
                Stock=500,
                Title="Aklından Bir Sayı Tut" },
            new Book{Id =3,CategoryID="A",AuthorID=3,Isbn="33333",
                Description="Christie'nin bu romanı 1933 yılında İstanbul'da, Pera Palas Otel'de yazılmıştır. Romanın giriş bölümü de İstanbul'da geçmektedir.",
                Price=300,
                Stock=1000,
                Title="Doğu Ekspresinde Cinayet" },

            new Book{Id =4,CategoryID="B",AuthorID=4,Isbn="44444",
                Description="Gazi Mustafa Kemal Atatürk'ün 1919'dan 1927'ye dek kendisinin ve silah arkadaşlarının faaliyetlerini özetlediği konuşmasının metnidir.",
                Price=240,
                Stock=2000,
                Title="Nutuk" },
            new Book{Id =5,CategoryID="B",AuthorID=5,Isbn="55555",
                Description="Turgut Özakman'ın Kurtuluş Savaşı dönemini anlattığı belgesel romandır.",
                Price=100,
                Stock=600,
                Title="Şu Çılgın Türkler" },
            new Book{Id =6,CategoryID="B",AuthorID=6,Isbn="66666",
                Description="İlber Ortaylı'nın Osmanlı-Türk tarihi türündeki kitabıdır.",
                Price=200,
                Stock=3000,
                Title="Yakın Tarihin Gerçekleri" },

            new Book{Id =7,CategoryID="C",AuthorID=7,Isbn="77777",
                Description="David D. Burns Bilişsel Davranışçı Terapi uygulamaları içeren bir self-help kitabıdır.",
                Price=260,
                Stock=1500,
                Title="İyi Hissetmek" },
            new Book{Id =8,CategoryID="C",AuthorID=8,Isbn="88888",
                Description="Engin Geçtan'ın Yaşamın anlamı ve amacı hakkında düşünceleri.",
                Price=140,
                Stock=750,
                Title="Hayat" },
            new Book{Id =9,CategoryID="C",AuthorID=9,Isbn="99999",
                Description="Erich Fromm tarafından 1956 yılında yazılmış, insan sevgisini büyük ölçüde kuramsal bir biçimde ele alan kitap.",
                Price=230,
                Stock=2700,
                Title="Sevme Sanatı" },
        };
    }

    public void Add(Book book)
    {
        _bookData.Add(book);
    }

    public void Delete(int id)
    {
        //foreach (Book book in _bookData)
        //{
        //    if (book.Id == id)
        //    {
        //        _bookData.Remove(book);
        //    }

        //}

        //Daha sık kullanılan
        Book? book = _bookData.Where(x => x.Id == id).SingleOrDefault();
        if (book is null)
        {
            throw new BookNotFoundException(id);
        }
        _bookData.Remove(book);
    }

    public List<Book> GetAll()
    {
        return _bookData;
    }

    public Book? GetById(int id)
    {
        Book? book = _bookData.SingleOrDefault(x => x.Id == id);
        if (book == null)
        {
            throw new BookNotFoundException(id);
        }

        return book;

    }

    public Book GetByIsbn(string isbn)
    {
        Book? book = _bookData.SingleOrDefault(x=>x.Isbn == isbn);
        if (book is null)
        {
            throw new BookNotFoundWithIsbnException(isbn);
        }
        return book;
    }
}
