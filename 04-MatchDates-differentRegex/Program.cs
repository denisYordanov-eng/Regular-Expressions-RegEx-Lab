using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_MatchDates_differentRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string datesInput = Console.ReadLine();
            string regex = @"\b(?<day>[0-9]{2})([.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})";

            var dates = Regex.Matches(datesInput, regex);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
