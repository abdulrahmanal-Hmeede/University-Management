namespace University_Management
{
    using CoreLibrary;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
           University u = new University();
            List<Teacher> ts = new List<Teacher> ();
            College college = new College("ahmed",200,ts,u);
            college.printData();
           
        }
    }
}
