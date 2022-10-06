using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7dotnet
{
    class Doctor
    {
        int RegnNo = 45678;
        string Name = "hima";
        double Feescharged = 300;
        public int _regnno
        {
            get { return RegnNo; }
            set { RegnNo = value; }
        }
        public string _name
        {
            get { return Name; }
            set { Name = value; }
        }
        public double _feescharged
        {
            get { return Feescharged; }
            set { Feescharged = value; }
        }
    }
    class Property
    {
        public static void Main()
    {
            Doctor doctor = new Doctor();
            Console.WriteLine(doctor._regnno + " " + doctor._name + " " + doctor._feescharged);
            doctor._regnno = 7867;
            doctor._name = "lagari";
            doctor._feescharged = 300;
            Console.WriteLine(doctor._regnno + " " + doctor._name + " " + doctor._feescharged);
            Console.ReadLine();


    }
      
    
    }

    
}
