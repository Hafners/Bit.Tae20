using System;
using Bit.Tae20.Data.Entities;
using Bit.Tae20.Data.Enumerations;

//Dom war hier
namespace Bit.Tae20.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zeichenkette
            string abc = "10a";
            //int a = int.Parse(abc);


            bool isValid = int.TryParse(abc, out int parsedValue);
            



            Console.WriteLine("Bitte gib einen Namen ein");
            string name = Console.ReadLine();

            Console.WriteLine("Bitte gib einen PLZ ein");
            string zipcode = Console.ReadLine();

            Customer customer1 = new Customer { Id = 1, Name = name, Zipcode = 0, Status = RowStatus.Active };


            Customer customer2 = new Customer();

            
            Console.WriteLine("Hallo Mark");
            Console.WriteLine("Hallo Dom!");
            Console.WriteLine("Hallo Vorname");
        }
    }
}
