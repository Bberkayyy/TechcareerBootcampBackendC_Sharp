﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Models
{
    public class Category:EntityBase<string>
    {
        public string Name { get; set; }
    }
}