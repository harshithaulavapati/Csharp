using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Create a class called Books with BookName and AuthorName members. Instantiate 
the class through constructor and also write a method Display() to display the details. 
Create an Indexer of Books Object to store 5 books in a class called BookShelf.
Using the indexer method assign values to the books and display the same.*/



namespace Assignment6
{
    class Books
    {
       
        
        string BookName;
        string AuthorName;
       
        public Books(string bname, string aname)
        {
            BookName = bname;

            AuthorName = aname;
        }

        public void display()
        {
            Console.WriteLine($"The Bookname  :- {BookName}\nThe Authorname :-  {AuthorName}");
        }

    }
    class BookShelf
    {
        string[] books = new string[5];
        public string this[int f]
        {
            get { string temp = books[f]; return temp; }
            set { books[f] = value; }
        }
    }
    class program
    { 

        static void Main(string[] args)
        {
            Books books = new Books("The Pilgrim's Progress","John Bunyan");
            books.display();
            BookShelf bookShelf = new BookShelf();
            bookShelf[0] = "Gulliver's Travels";
            bookShelf[1] = "Tom Jones";
            bookShelf[2] = "The Book Thief";
            bookShelf[3] = "leaving Time";
            bookShelf[4] = "Until the End of Time";
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("displaying the five types of books :-");
            Console.WriteLine($"the first books name : { bookShelf[0]}\nthe second book name :{bookShelf[1]}\nthe third book name:{bookShelf[2]}\nthe fourth book name:{bookShelf[3]}\nthe fifth book name:{bookShelf[4]} ");
            
            Console.Read();


        }
    }
}
