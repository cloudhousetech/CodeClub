using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountryCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string[]> countries = new List<string[]>(); 
            string[] lines = File.ReadAllLines(@"\\nasbox\development\content.txt");
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                countries.Add(values);
            }
            Console.WriteLine("Enter a Country");
            string countryin = Console.ReadLine();
            string currency = string.Empty;
            foreach (string[] country in countries)
            {
                if (country[0] == countryin)
                {
                    currency = country[2];                   
                    break;
                }
            }
            Console.WriteLine($"Currency for {countryin} is {currency}");
            Console.ReadKey();
        }   
    }
}
