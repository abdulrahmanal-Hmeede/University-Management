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
            University u = new University("iusr",2015, colleges, universityType.PrivateUniversity);
            u.print();
            //University.universityType.PublicUniversity
            List <Teacher> ts = new List<Teacher> ();
            College college = new College("ahmed",200,ts,u);
            college.printData();
            //Helpers h = new Helpers();
            
           
        }
    }
}
