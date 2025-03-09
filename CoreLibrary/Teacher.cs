using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    
        public class Teacher
        {
            public static int counter;
            private int id;
            public int Id
            {
                get { return Id; }
                set
                {
                    id = value;
                }
            }
            private string name;
            public string Name
            {
                get { return name; }
                set
                {
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
            private string specialization;
            public string Specialization
            {
                get { return specialization; }
                set
                {
                    if (value.Length >= 2)
                    {
                        specialization = value;
                    }
                    else
                    {
                        throw new Exception("Error in Specialization Length!");
                    }
                }
            }
            private double salary;
            public double Salary
            {
                get { return salary; }
                set
                {
                    if (value > 0)
                    {
                        salary = value;
                    }
                    else
                    {
                        throw new Exception("Error in Salary Value!");
                    }
                }
            }
            public University university;
            public College college;

            public Teacher(string name, string sp, double salary)
            {
                this.Id = ++counter;
                this.Name = name;
                this.Specialization = sp;
                this.Salary = salary;
            }

            // Print Data
            public void printData()
            {
                Console.WriteLine("- Id: " + id);
                Console.WriteLine("- Name: " + name);
                Console.WriteLine("- specialization");
            }

        }
    }

