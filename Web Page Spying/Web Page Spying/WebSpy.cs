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
    public class WebSpy : IDisposable
    {
        WebClient client;
        StreamWriter writer = null;
        private string html { get; set; }

        public WebSpy(string url)
        {
            client = new WebClient();
            html = client.DownloadString(url);
        }

        public List<string> FindeURLs()
        {
            List<string> URLs = new List<string>();
            Regex regex = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?", RegexOptions.IgnoreCase);
            Match match;
            for (match = regex.Match(html); match.Success; match = match.NextMatch())
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

        // saves urls to txt file
        public void SaveURLsToDoc(string path)
        {
            List<string> urlLists = FindeURLs();
            writer = new StreamWriter(path);

            foreach (var urls in urlLists)
            {
                writer.WriteLine(urls);
            }
            writer.Close();    
        }

        // saves web constent  to txt file and cleans html tags
        public void SaveWebContentToDoc(string OutputFileName)
        {
            try
            {
                Encoding encoding = Encoding.GetEncoding("windows-1251");
                writer = new StreamWriter(OutputFileName, false, encoding);
                RemoveHtmlTags(writer);
            }
            catch (IOException)
            {
                Console.WriteLine("Cannot save file ");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }


        //Removes the tags from a HTML text
        private void RemoveHtmlTags(StreamWriter writer)
        {
            StringBuilder buffer = new StringBuilder();
            bool inTag = false;
            
            for(int i = 0; i < html.Length; i++)
            {
                int nextChar = html[i];
                if (nextChar == -1)
                {
                    // End of file reached
                    PrintBuffer(writer, buffer);
                    break;
                }
                char ch = (char)nextChar;
                if (ch == '<')
                {
                    if (!inTag)
                    {
                        PrintBuffer(writer, buffer);
                    }
                    buffer.Clear();
                    inTag = true;
                }
                else if (ch == '>')
                {
                    inTag = false;
                }
                else
                {
                    // We have other character (not "<" or ">")
                    if (!inTag)
                    {
                        buffer.Append(ch);
                    }
                }
            }
        }

        //Removes the whitespace and prints the buffer in a file
        private void PrintBuffer(StreamWriter writer, StringBuilder buffer)
        {
            Regex regexWhitespace = new Regex("\n\\s+");
            string str = buffer.ToString();
            string trimmed = str.Trim();
            string textOnly = regexWhitespace.Replace(trimmed, "\n");
            if (!string.IsNullOrEmpty(textOnly))
            {
                writer.WriteLine(textOnly);
            }
        }


        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    client.Dispose();
                    writer.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~WebSpy() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
