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
        private WebClient client;
        private StreamWriter writer = null;
        private string HtmlContent { get; set; }
        private string url { get; set; }
        public List<string> InnerURLs { get; set;  }

        public WebSpy(string inputUrl)
        {
            url = inputUrl;
            client = new WebClient();
            HtmlContent = client.DownloadString(url);
            InnerURLs = new List<string>();
            Regex regExpression = new Regex("(?:href)=[\"|']?(.*?)[\"|'|>]+", RegexOptions.Singleline | RegexOptions.CultureInvariant);
            if (regExpression.IsMatch(HtmlContent))
            {
                string matchValue;
                foreach (Match match in regExpression.Matches(HtmlContent))
                {
                    matchValue = match.Groups[1].Value;
                    InnerURLs.Add(matchValue);
                }
            }
        }

        // saves urls to txt file
        public void SaveURLsToDoc(string OutputFileName)
        {
            try
            {
                writer = new StreamWriter(OutputFileName);
                foreach (var urls in InnerURLs)
                {
                    writer.WriteLine(urls);
                }
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
            
            for(int i = 0; i < HtmlContent.Length; i++)
            {
                int nextChar = HtmlContent[i];
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

        //saves pictures
        public void SavePicturesToDoc(string OutputFileName)
        {
            Directory.CreateDirectory(OutputFileName);
            var imageURLs = showMatch(HtmlContent, @"<(img)\b[^>]*>");      
            string[] split = imageURLs.Split(new Char[] { '"', '?' });
            int PictureNumber = 1;

            foreach (var item in split)
            {

                if (item.Contains(".jpg"))
                {
                    client = new WebClient();
                    Uri uri = new Uri(url + item);
                    client.DownloadFileAsync(uri, $"{OutputFileName}\\Picture{PictureNumber}.jpg");
                    PictureNumber++;
                    Console.WriteLine(item);
                }

                if (item.Contains(".png"))
                {
                    client = new WebClient();
                    Uri uri = new Uri(url + item);
                    client.DownloadFileAsync(uri, $"{OutputFileName}\\Picture{PictureNumber}.png");
                    PictureNumber++;
                    Console.WriteLine(item);
                }

                if (item.Contains(".svg"))
                {
                    client = new WebClient();
                    Uri uri = new Uri(url + item);
                    client.DownloadFileAsync(uri, $"{OutputFileName}\\Picture{PictureNumber}.svg");
                    PictureNumber++;
                    Console.WriteLine(item);
                }
            }

        }
        private string showMatch(string text, string expr)
        {
            MatchCollection mc = Regex.Matches(text, expr);
            string result = "";
            foreach (Match m in mc)
            {
                result += m.ToString() + "\n";
            }
            return result;
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
                    Console.WriteLine("worked");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                client = null;
                writer = null;

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

