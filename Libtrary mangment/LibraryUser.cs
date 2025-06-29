using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libtrary_mangment
{
    internal class LibraryUser:User
    {
        //inherit from the abstract class user and can display the books to barrow 
       public LibraryCard card { get; set;}
        
        public void BorrowBook(Book book,Library library)
        {
            library.borrwodBook(book);
            //add the logic 
            //enter the name of the title
            //transform the book to the aother array of the barrowed books
            //delete the book from the books array
        }
        public LibraryUser(LibraryCard card,string name)
        {
            this.Name = name;
            this.card = card;
        }
    }
}
