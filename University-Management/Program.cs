namespace University_Management
{
    using CoreLibrary;
    using HelpersLibrary;
    using System.Collections.Generic;
    using OperationsLibrary;
    using static CoreLibrary.University;
    using System.Xml.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<College> colleges = new List<College>();
            //University u = new University("iusr", 2015, colleges, universityType.PrivateUniversity);

            //University.universityType.PublicUniversity
            List<Teacher> ts = new List<Teacher>();
            //College college = new College("ahmed", 200, ts, u);
            //college.printData();
            //Helpers h = new Helpers();
<<<<<<< HEAD
            
          
=======

            Operation p = new Operation();
            //p.AddToFile(@"Data\new.txt", "new text");
            p.AddToFile(@"Data\Universities\swada.txt", "Ez");




>>>>>>> 91cf916e1592e6db07336de784e2f6dffc008fdc
        }
    }
}
