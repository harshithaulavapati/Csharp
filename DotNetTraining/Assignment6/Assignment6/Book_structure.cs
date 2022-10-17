using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a structure 
struct Books
private string title;
private string author;
private string subject;
private int book_id;
Include 2 methods called GetValues() and ShowValues() to accept and display details.
create a Class called TestStructures that invokes the above methods of the structure to accept and display the details of the book*/

namespace Assignment6
{
    struct Book_structure
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void GetValues()
        {
            title = "the c# language";
            author = "Anders Hejlsberg";
            subject = "programming";
            book_id = 30004;
        }
        public void ShowValues()
        {
            Console.WriteLine($"The title :-{title}\nThe Author :-{author}\nThe Subject :-{subject}\nThe Book Id :-{book_id}");
        }
    }
    class TestStructures
    {
        public static void Main ()
        {
            Book_structure book_Structure = new Book_structure();
            book_Structure.GetValues();
            book_Structure.ShowValues();
            Console.Read();
        }
    }

}
