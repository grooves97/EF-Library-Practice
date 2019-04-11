using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary.Models
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ICollection<Author> Author { get; set; }
    }
}
