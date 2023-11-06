

namespace Bootcamp_Day4_BookProject.Models;

public class Book :EntityBase<int>
{
    public string Description { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public string Title { get; set; }

    public string Isbn { get; set; }

    public string CategoryID { get; set; }
    public int AuthorID { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}\nKategori Id : {CategoryID}\nYazar Id : {AuthorID}\nBaşlık: {Title}\nDescription: {Description}\nStock: {Stock}\nPrice: {Price}\n";
    }
}
