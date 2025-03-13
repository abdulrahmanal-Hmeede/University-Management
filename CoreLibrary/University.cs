using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class University
    {
        //public static List<University> universities = new List<University>();

        //public List<College> Colleges= new List<College>();


        public enum universityType
        {
            PublicUniversity,
            PrivateUniversity
        };

        private universityType type;
        private static int counter = 1;
        private int id;
        private int universityOpeningYear;
        private string name;
        public List<College> college;

        public universityType Type
        {
            get { return type; }
            set { type = value; }
        }

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
                universityOpeningYear = value;
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

        public University(string Name, int UniversityOpeningYear,List<College> college,universityType Type)
        {
            id = counter++;
            this.Name = Name;
            this.UniversityOpeningYear = UniversityOpeningYear;
            this.college = college;
            this.Type = Type;

        }

        //تحقق من طلبات الطباعة داخل القوسين
        public void print()
        {
            Console.WriteLine(
                $"Id: {id}," +
                $" Name: {name}," +
                $"university Opening Year : {universityOpeningYear}" +
                $"university Type : {Type}");
        }


    }
}
