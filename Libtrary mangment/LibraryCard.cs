using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libtrary_mangment
{
    internal class LibraryCard
    {
        public string Number  { get; set; }
        public LibraryCard(string number)
        {
            Number = number;
        }
    }
}
