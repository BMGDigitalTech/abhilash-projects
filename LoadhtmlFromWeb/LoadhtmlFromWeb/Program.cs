using HtmlAgilityPack;
using System;

namespace LoadhtmlFromWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = @"https://www.google.com";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            //var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            Console.WriteLine("Node Name" + node.Name + "\n" + node.OuterHtml);

            Console.ReadKey();
        }
    }
}
