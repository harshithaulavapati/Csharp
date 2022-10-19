using System;



namespace Assignment6
{
    class Book
    {
        string BookName;
        string AuthorName;

        public Book(string BookName, string AuthorName)
        {
           this.BookName = BookName ;

            this.AuthorName =AuthorName ;
        }

        public void displaydetails()
        {
            Console.WriteLine($"The BookName  :- {BookName}\tThe AuthorName :-  {AuthorName}");
        }
    }
    class BookShelfClass
    {
        Book[] book = new Book[5];

        public Book this[int f]
            {
            get { return book[(int)f]; }
            set { book[(int) f] = value; }

            }

        
    }

    class Test
    {
        static void Main()
        {
            BookShelfClass bc = new BookShelfClass();
            bc[0]= new Book("Gulliver's Travels", "johnathan swift");
            bc[1] = new Book("Tom Jones", "Henry fielding");
            bc[2] = new Book("The Book Thief", "Markus Zusak");
            bc[3] = new Book("leaving Time", "jodi Picoult");
            bc[4] = new Book("Until the End of Time", "Brian Greene");

            for(int i=0;i<5;i++)
            {
                 bc[i].displaydetails();
            }
            Console.Read();
        }
    }
}
