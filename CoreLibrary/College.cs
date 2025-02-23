using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class College
    {
        // state
        public static int counter=1;
        private int id;
        private string name;
        private int numberOfStudent;
        public List<Teacher> teachers;
        public University university;



        // filds
        public int Id { 
            get { 
            return id;
            }
            set
            { 
                id = value;
            }
        }
        public string Name { 
            get { 
            return name;
            } 
            set {
                if (value.Length >= 2)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Error in Name Length!");
                }
            }
        }

        
        public int NumberOfStudent {
            get { 
            return numberOfStudent;
            }
            set {
                if( value > 0)
                {
                    numberOfStudent = value;
                }
            }
        }

        // The Constractor
        public College(string inName, int inNumberOfStudent, List<Teacher> teachers, University inUniversity)
        {
            Id= counter++;
            Name = inName;
            NumberOfStudent = inNumberOfStudent;
            this.teachers = teachers;
            this.university = inUniversity;
        }

        // Print college information
        public void printData()
        {
            Console.WriteLine($"Id: {id}, Name: {name}, Number Of Student: {numberOfStudent}, University: {university}, ");
        }


        // Return teachers
        public List<Teacher> GetTeachers()
        {
            return teachers;
        }
    }
}
