using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_MatchHexadecimalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string matchPatern = @"\b(?:0X|0x)?([0-9A-Fa-f]+)\b";

            string numberAsString = Console.ReadLine();

            var Hexnumbers = Regex.Matches(numberAsString,matchPatern)
                .Cast<Match>()
                .Select(a =>a.Value)
                .ToArray();

            Console.WriteLine(String.Join(" ", Hexnumbers));
        }
    }
}
