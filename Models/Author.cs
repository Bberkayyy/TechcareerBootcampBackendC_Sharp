using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Models;

public class Author : EntityBase<int>
{
    public  string Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, İsim : {Name}";
    }
}
