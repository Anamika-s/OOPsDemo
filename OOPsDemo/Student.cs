using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class  Student
    {
        int id;
        string name;



        
        static string batchName="B001111111111111111111111111111111";
        public const string company="CGI";
        
        public void GetDetails()
        {
            Console.WriteLine("Enter I222232323232323d");
            id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Id is {id}");
            Console.WriteLine($"Name is {name}");
             

            }
        public static void DisplayBatch()
        {
            batchName = "B002";
            Console.WriteLine($"batchName is {batchName}");
             

        }
    }
}
