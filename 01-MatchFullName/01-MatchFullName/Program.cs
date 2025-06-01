using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string matchPatern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            
            Regex regex = new Regex(matchPatern);
            MatchCollection match = regex.Matches(words);

        

            foreach (Match m in match)
            {
              Console.Write(m.ToString() + " ");
            }
           
        }
    }
}
