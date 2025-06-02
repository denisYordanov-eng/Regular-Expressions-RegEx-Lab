using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_Replace_Tag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input !="end")
            {
                var patern = @"<a\s+href\s*=\s*""(.*?)"">(.*?)</a>";
                string replacement = @"[URL href=""$1""]$2[/URL]";
                var result = Regex.Replace(input,patern,replacement);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }

        }
    }
}
