using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse String: \n");

            string line_to_reverse = Console.ReadLine();
            int index_number = line_to_reverse.Length - 1;
            int counter = 0; 
            List<char> chararr = new List<char>();

            foreach(char c in line_to_reverse)
            {
                chararr.Add(line_to_reverse.ElementAt(index_number - counter));
                counter += 1;
            }

            Console.WriteLine();

            foreach(char c in chararr)
            {
                Console.Write(c);
            }

            Console.ReadKey();

        }
    }
}
