using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        string name;
        string isbn;
        string author;
        string publisher;
        DateTime year;
        public static string Name { get; set; }
        public static string Isbn { get; set; }
        public static string Author { get; set; }
        public static string Publisher { get; set; }
        public static DateTime Year { get; set; }

        public override string ToString()
        {
            return $"{Name}{Isbn}{Year}".ToString();
        }
    }
}
