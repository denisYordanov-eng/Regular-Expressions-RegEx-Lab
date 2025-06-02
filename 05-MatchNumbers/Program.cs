using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace _05_MatchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string input = Console.ReadLine();
            var numbersMatch = Regex.Matches(input, regex);

            foreach (Match number in numbersMatch)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
