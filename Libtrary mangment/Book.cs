using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libtrary_mangment
{
    internal class Book
    {
       
        public string title { get; set; }
        public string author { get; set; }
       
        public int year { get; set; }
        public Book( string title, string author, int year  )
        {
            
            this.title = title;
            this.author = author;
            this.year = year;
        }
       public void BookDisaply()
        {
            Console.WriteLine($"TITILE {this.title} AUTHOR : {this.author} YEAR {this.year}");
        }
    }
}
