using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace _04_MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patern = @"\b(?<day>\d{2})([.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var dateMatches = Regex.Matches(input, patern);

            foreach (Match date in dateMatches)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}