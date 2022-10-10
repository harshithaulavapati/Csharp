using System;



namespace Assignment5

{
    class PassengerException : ApplicationException
    {
        public PassengerException(string msg) : base(msg)
        {

        }
    }
     class Ticket
    {
        string Name;
        int age;
        int ticket;
        
        public void TicketBooking()
        {
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Tickets :");
           ticket = Convert.ToInt32(Console.ReadLine());
            if (ticket > 2)
            {
                throw (new PassengerException("Cannot book more than 2 tickets."));
               
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
   
        




    }
    class Details
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();
            try
            {
                ticket.TicketBooking();
            }
            catch (PassengerException pe)
            {
                Console.WriteLine(pe.Message);
            }
           Console.ReadKey();
        }
    }


}