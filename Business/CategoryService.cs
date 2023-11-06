using Bootcamp_Day4_BookProject.Data;
using Bootcamp_Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Business;

public class CategoryService : ICategoryService
{

    private readonly ICategoryRepository _categoryReposirtory;

    public CategoryService(ICategoryRepository categoryReposirtory)
    {
        _categoryReposirtory = categoryReposirtory;
    }
    /// <summary>
    /// Kategori listesini ekrana yazdırır.
    /// </summary>
    public void GetList()
    {
        _categoryReposirtory
            .GetAll()
            .ForEach(category => Console.WriteLine(category));
    }
}
