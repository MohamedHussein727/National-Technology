using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace National_Technology.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string  Title { get; set; }
        public int Price { get; set; }
        public int Reserved { get; set; }
        
         
    }
}