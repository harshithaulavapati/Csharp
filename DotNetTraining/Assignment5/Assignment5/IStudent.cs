using System;
namespace Assignment5
{
    interface IStudent
    {

        int StuentID { get; set; }
        string Name { get; set; }

    }
    class Dayscholar : IStudent
    {
        public int StuentID { get; set; }

        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine(" the dayscholar details");
            Console.WriteLine($"  the student id :  {StuentID}, the Name of the student : {Name} ");

        }
    }
    class Resident : IStudent

    {
        public int StuentID { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            
            Console.WriteLine(" the Resident details");
            Console.WriteLine($"  the student id  :  {StuentID}, the Name of the student : {Name}");
        }
        
    }
    class Studentdetails
    {
        static void Main(string[] args)
        {
            Dayscholar dayscholar = new Dayscholar();
            dayscholar.StuentID = 234;
            dayscholar.Name = "honey";
            Resident resident = new Resident();
            resident.StuentID = 567;
            resident.Name = "lahari";
            dayscholar.ShowDetails();
            resident.ShowDetails();
            Console.ReadLine();


        }
    }

}
