// See https://aka.ms/new-console-template for more information

using Bootcamp_Day4_BookProject.Business;
using Bootcamp_Day4_BookProject.Data;

using Bootcamp_Day4_BookProject.Models;

IBookService bookService = new BookService(new BookRepository());
IAuthorService authorService = new AuthorService(new AuthorRepository());

bookService.GetList();
Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
authorService.GetList();

//Book book = new Book()
//{
//    Id = 4,
//    Description = "test",
//    Price = -1,
//    Stock = 100,
//    Title = "Te",
//};

Author author = new Author()
{
    Id = 10,
    Name="Buse Kudun",
    
};

//Console.WriteLine("Kayıt Ekleme : ");
//bookService.Add(book);

//Console.WriteLine("Kayıt Silme : ");
//bookService.Delete(2);

//Console.WriteLine("Id ye göre getirme : ");
//bookService.GetById(2);

//Console.WriteLine("Kitap Listesi : ");
//bookService.GetList();

//bookService.GetByIsbn("12121");

//-------------------------------------------------------------------------------------------
//Console.WriteLine("Kayıt Ekleme : ");
//authorService.Add(author);

//Console.WriteLine("Kayıt Silme : ");
//authorService.Delete(6);

//Console.WriteLine("Id ye göre getirme : ");
//authorService.GetById(4);

//Console.WriteLine("Yazar Listesi : ");
//authorService.GetList();
