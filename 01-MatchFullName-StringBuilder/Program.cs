using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_MatchFullName_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string words = Console.ReadLine();
            var patern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";

            Regex regex = new Regex(patern);
            MatchCollection matches = regex.Matches(words);

            StringBuilder sb = new StringBuilder();
            foreach (Match m in regex.Matches(words))
            {
                sb.Append(m.ToString()).Append(" "); 
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
