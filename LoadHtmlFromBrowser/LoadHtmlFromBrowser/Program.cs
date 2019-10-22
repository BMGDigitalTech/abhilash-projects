using HtmlAgilityPack;
using System;

namespace LoadHtmlFromBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://html-agility-pack/from-browser";

            var web1 = new HtmlWeb();
            var doc1 = web1.LoadFromBrowser(url, o =>
            {
                var webBrowser = (WebBrowser)o;

                // WAIT until the dynamic text is set
                return !string.IsNullOrEmpty(webBrowser.Document.GetElementById("uiDynamicText").InnerText);
            });
            var t1 = doc1.DocumentNode.SelectSingleNode("//div[@id='uiDynamicText']").InnerText;

            var web2 = new HtmlWeb();
            var doc2 = web2.LoadFromBrowser(url, html =>
            {
                // WAIT until the dynamic text is set
                return !html.Contains("<div id=\"uiDynamicText\"></div>");
            });
            var t2 = doc2.DocumentNode.SelectSingleNode("//div[@id='uiDynamicText']").InnerText;

            Console.WriteLine("Text 1: " + t1);
            Console.WriteLine("Text 2: " + t2);

        }
    }
}
