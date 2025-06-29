using System.Runtime.InteropServices;

namespace Libtrary_mangment
{
    internal class Program
    {
        static Book IntializeBook()
        {
            Console.WriteLine("enter the book title");
            string bookTitle = Console.ReadLine();
            //
            Console.WriteLine("Enter the author");
            string author = Console.ReadLine();
            //
            Console.WriteLine("Enter the year of publish");
            int yearPublish = int.Parse(Console.ReadLine());
            Book book = new Book(bookTitle, author, yearPublish);
            return book;
        }
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.WriteLine("welcom to the library");
            Console.WriteLine("Are you librarian or User [L/U]");
            char userInput = Console.ReadLine().ToUpper()[0];
            if (userInput == 'L')
            {
       
                Console.WriteLine("Please enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your Employee number");
                int number=int.Parse(Console.ReadLine());
                Libarain libarain = new Libarain(name,number);
                Console.WriteLine($"Welcome to the Application {libarain.Name}");
                while (true)
                {
                    Console.WriteLine("PLease enter you choice\n  1- Add book \n 2 remove book \n 3 - display all books\n 0- to exit");
                int Choice =int.Parse(Console.ReadLine());
                
                    switch (Choice)
                    {
                        case 1:
                            Book book = IntializeBook();
                            libarain.AddBook(book, library);
                            break;
                        case 2:
                   
                            Book removebook = IntializeBook();
                            libarain.RemoveBook(removebook, library);

                            break;
                        case 3:
                            libarain.DisplayBook(library);
                            break;
                        default: 
                            Environment.Exit(0);
                            break;
                    }
                }
                
            }
            
            else if(userInput=='U')
            {
                Console.WriteLine("enter you name to continue");
                string name=Console.ReadLine();
                Console.WriteLine("Please enter your libray card number before going further");
                string libraryCardNumber=Console.ReadLine();
                LibraryCard libraryCard=new LibraryCard(libraryCardNumber);
                LibraryUser libraryUser = new LibraryUser(libraryCard,name);
                Console.WriteLine($"you have been registered with the card number {libraryUser.card.Number}");
               
                while (true)
                {
                    Console.WriteLine("please enter your choice 1 - borrow book 2 - Display all books");
                    int useranswer = int.Parse(Console.ReadLine());
                    switch (useranswer)
                    {
                        case 1:

                            Book book = IntializeBook();
                            libraryUser.BorrowBook(book, library);
                            break;
                        case 2:
                            libraryUser.DisplayBook(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter valid choice between the both L / R");//handle the invalid choice of the user
            }

        }
    }
}
