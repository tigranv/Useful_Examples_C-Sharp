using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Web_Page_Spying
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://en.wikipedia.org/wiki/C_Sharp_(programming_language)";

            
            List<string> URLs = FindeURLs(html);

            foreach (var item in URLs)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }


        


    }
}
