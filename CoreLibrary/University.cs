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
        public enum universityType
        {
            PublicUniversity,
            PrivateUniversity
        };
        

        // state
        private static int counter = 0;
        private universityType type;
        private int id;
        private int universityOpeningYear;
        private string name;
        public List<College> colleges;


        
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
        public University(string Name, int UniversityOpeningYear,List<College> college,universityType Type)
        {
            id = ++counter;
            this.Name = Name;
            this.UniversityOpeningYear = UniversityOpeningYear;
            this.colleges = college;
            this.Type = Type;

        }

        public void print()
        {
                Console.WriteLine(
                $"Id: {id} ," +
                $" Name: {name}," +
                $"university Opening Year : {universityOpeningYear}, " +
                $"university Type : {Type} ");
        }


    }
}
