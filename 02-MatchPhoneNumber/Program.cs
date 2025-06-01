using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace _02_MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPhoneNumbers = Console.ReadLine();

            string match = @"(?<=\s|^)\+359([ -])2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(match);

            MatchCollection matches = regex.Matches(inputPhoneNumbers);

            List<Match> result = new List<Match>();
            foreach (Match m in regex.Matches(inputPhoneNumbers))
            {
                result.Add(m);
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
