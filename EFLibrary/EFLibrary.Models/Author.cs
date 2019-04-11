﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary.Models
{
    public class Author : Entity
    {
        public string Fullname { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}
