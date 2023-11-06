using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Consts;

public class Messages
{
    public static string BookTitleExceptionMessage(string title)
    {
        return $"Girilen başlık '{title}' en az 3 karaterli olmalıdır. ({title.Length})";
    }

    public static string BookPriceAndStockExceptionMessage(double price, int stock)
    {
        return $"Girilen ürün fiyatı ve stok miktarı negatif olamaz. Stok : {stock}, Fiyat : {price}";
    }

    public static string BookNotFoundExceptionMessage(int id)
    {
        return $"{id} numaralı Id'ye ait kitap bulunamadı.";
    }
    public static string AuthorNotFoundExceptionMessage(int id)
    {
        return $"{id} numaralı Id'ye ait yazar bulunamadı.";
    }
    public static string AuthorNameExceptionMessage(string name)
    {
        return $"Girilen yazar adı '{name}' en az 3 karakterli olmalıdır. ({name.Length})";
    }
    public static string BookNotFoundWithIsbnExceptionMessage(string isbn)
    {
        return $"Girilen {isbn} ait kitap bulunamadı.";
    }
}
