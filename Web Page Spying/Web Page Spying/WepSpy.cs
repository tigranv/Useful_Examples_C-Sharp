using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Web_Page_Spying
{
    public class WepSpy
    {
        WebClient client = new WebClient();
        string html;

        public WepSpy(string url)
        {
            html = client.DownloadString(url);
        }




        public static List<string> FindeURLs(string input)
        {
            List<string> URLs = new List<string>();
            Regex regex = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?", RegexOptions.IgnoreCase);
            Match match;
            for (match = regex.Match(input); match.Success; match = match.NextMatch())
            {

                foreach (Group group in match.Groups)
                {
                    if (group.ToString().StartsWith("http") || group.ToString().Contains("@"))
                    {
                        URLs.Add(group.ToString());
                    }

                }
            }
            return URLs;
        }
    }
}
