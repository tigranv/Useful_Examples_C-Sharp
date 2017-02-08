using System;
using System.Collections.Generic;
using System.IO;
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
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path1 = Path.Combine(desktop, "URLsList.txt");
            var path2 = Path.Combine(desktop, "WebContent.txt");
            var path3 = Path.Combine(desktop, "WebPictures");
            Console.WriteLine("Enter the url");
            string url = Console.ReadLine();

            using (WebSpy WebSpyer = new WebSpy(url))
            {
                // write urls in txt
                WebSpyer.SaveURLsToDoc(path1);
                Console.WriteLine("All URLs writen in txt document on your desktop");

                //clean web content from html tags and write in txt
                WebSpyer.SaveWebContentToDoc(path2);
                Console.WriteLine("Content of Web page is cleared from html tags and writen in txt document on your desktop");

                // write urls in txt
                WebSpyer.SavePicturesToDoc(path3);
                Console.WriteLine("All pictures from Web page saved in document on your desktop");
            }

            Console.ReadKey();
        }
    }
}
