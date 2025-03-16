using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class University
    {

        // state
        private static int counter = 0;
        private int id;
        private string name;
        private int universityOpeningYear;
        public string type;
        public List<College> colleges;
        public static List<University> universities = new List<University>();


        public int Id
        {
            get
            {
                return id;
            }
        }

        public int UniversityOpeningYear
        {
            get
            {
                return universityOpeningYear;
            }
            set
            {

                if (value < 2025 && value > 1800) {
                    universityOpeningYear = value;
                }
                else
                {
                    //////////////////////////////
                }
                
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 3)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Retype the name");
                }
            }
        }

        public University() 
        {

        }
        public University(string Name, int UniversityOpeningYear,string Type)
        {
            id = ++counter;
            this.Name = Name;
            this.UniversityOpeningYear = UniversityOpeningYear;
            universities.Add(this);
            this.type = Type;

        }
        public University(string Name, int UniversityOpeningYear,List<College> college,string Type)
        {
            id = ++counter;
            this.Name = Name;
            this.UniversityOpeningYear = UniversityOpeningYear;
            this.colleges = college;
            this.type = Type;

        }

        public void print()
        {
                Console.WriteLine(
                $"Id: {id} ," +
                $" Name: {name}," +
                $"university Opening Year : {universityOpeningYear}, " +
                $"university Type : {type} ");
        }


    }
}
