﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OperationsLibrary
{

    public interface Ioperation
    {
        void AddToFile(string Src,string CountForAdd);
        void DeletTextToFile(string Src, string CountentForDelet);
        void EditFile(string Src, string NewContent);
    }

    public class Operation : Ioperation
    {
        
        
        
        //Method For Add txt to File :
        public void AddToFile(string Src, string ContentToAdd)
        {
            try
            {
                File.AppendAllText(Src, ContentToAdd);
                Console.WriteLine("Added to the text...");
            }
            catch (Exception x)
            {
                Console.WriteLine($"Error : {x.Message} ");
            }
    }


        //Method to delet
        public void DeletTextToFile(string Src, string CountentForDelet) 
        {
            
             try
              {
                if (File.Exists(Src))
                {
                    File.Delete(Src);
                    Console.WriteLine("The file has been permanently deleted...");
                }
                
                else
                {
                        throw new Exception("File not found !!!");
                }
              }

                catch (Exception x)
                {
                    Console.WriteLine($" Error : {x.Message}");
                }
        }


        //Method For Edit File :
        public void EditFile(string Src, string NewContent)
        {
           
            if (File.Exists(Src))
            {
              
                File.WriteAllText(Src, NewContent);
                Console.WriteLine("The file has been modified...");
            }
            else
            {
                throw new Exception("File not found !!!");
            }
        }
    }
}

