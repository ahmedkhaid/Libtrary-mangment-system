using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libtrary_mangment
{
    internal class Libarain:User
    {
        public int EmployeeNumber { get; set; }
        public void AddBook(Book newbook,Library library)
        {
            //add the logic later
            library.AddBook(newbook);//sepration of concerns in solid princible and clean code

        }
        public void RemoveBook(Book newbook,Library library)
        {
            //add the logic later
            library.RemoveBook(newbook);//also seprartion of conserns
        }
        public Libarain(string name,int employeeNumber)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
        }
        public void DisplayBook(Library library)
        {
            library.Display();
        }
    }
}
