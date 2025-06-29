using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libtrary_mangment
{
    internal class Library
    {
        private int currentBook = 0;
        private int currentborrowedbook = 0;
        private Book[] books =new Book[100];
        private Book[] barrowedBooks =new Book[50];
        public void Display()
        {
            Console.Clear();
            if (currentBook > 0)
            {
                Console.WriteLine("the books available in the library \n");
               for(int i=0;i<currentBook;i++)
                {
                    books[i].BookDisaply();
                }
            }
            else {
                Console.WriteLine("there is no avaliable book to barrow at the moment");
            }
            //Display all books
            
            Console.WriteLine("the list of books are borrowed\n");
            for (int i = 0; i < currentborrowedbook; i++)
            {
                barrowedBooks[i].BookDisaply();
            }
        }
        public void AddBook(Book a)
        {
            if(currentBook==100)
            {
                Console.WriteLine("the library is full cant add more");
            }
            else
            {
                books[currentBook] = a;
                currentBook++;// puting the cursor to the next avalible index
                Console.WriteLine("book added successfully");
            }

        }
        public void RemoveBook(Book a) {
            
            int indexofremovedBook=Array.IndexOf(books, a);
            if (indexofremovedBook==-1)
            { Console.WriteLine("the book not found");
                return;
            }
            if(indexofremovedBook==currentBook-1)
            {
                books[indexofremovedBook] = null;
                currentBook--;
            }
            else
            {
                for (int i = indexofremovedBook; i < currentBook-1; i++)
                {
                    books[i] = books[i + 1]; //
                }
                books[currentBook-1] = null;//clear the last duplicate value
                currentBook--;
            }
        }
        public void borrwodBook(Book book)
        {
            if (currentborrowedbook < 50)
            {
                barrowedBooks[currentborrowedbook] = book;
                Console.WriteLine("the book has been borrrowed successfuly");
                currentborrowedbook++;
                //RemoveBook(book);
            }
            else {
                Console.WriteLine("sorry the maximum number has been reached to borrow");
            }

        }
    }
}
