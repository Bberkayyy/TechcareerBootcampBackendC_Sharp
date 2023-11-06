using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Models;

//Generic programlama
public abstract class EntityBase<TypeOfID>
{
    public TypeOfID Id { get; set; }
}
