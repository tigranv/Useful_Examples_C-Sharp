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
            string url = "http://www.micarmenia.am/";

            WebClient client = new WebClient();
            string html = client.DownloadString(url);

            FindHrefs(html);

            Console.ReadKey();
        }


        private static void FindHrefs(string input)
        {
            Regex regex = new Regex("href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))", RegexOptions.IgnoreCase);
            Match match;
            for (match = regex.Match(input); match.Success; match = match.NextMatch())
            {

                foreach (Group group in match.Groups)
                {
                    Console.WriteLine(group);
                }
            }

        }


    }
}
