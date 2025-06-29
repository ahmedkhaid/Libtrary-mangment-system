using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libtrary_mangment
{
    internal abstract class User
    {
        public  string Name { get; set; }
        public void DisplayBook(Library library)//handling this later must return array of books
        {
            //add the logic later
            library.Display();
        }
    }
}
