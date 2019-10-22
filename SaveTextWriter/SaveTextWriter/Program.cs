using System;
using System.IO;
using HtmlAgilityPack;

namespace SaveTextWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var html =
        @"<!DOCTYPE html>
        <html>
        <body>
	        <h1>This is <b>bold</b> heading</h1>
	        <p>This is <u>underlined</u> paragraph</p>
	        <h2>This is <i>italic</i> heading</h2>
	        <h2>This is new heading</h2>
        </body>
        </html> ";

         var htmlDoc = new HtmlDocument();
         htmlDoc.LoadHtml(html);

         TextWriter tw = File.CreateText("TextWriter.html");

         htmlDoc.Save(tw);

         tw.Close();

         var htmlNewDoc = new HtmlDocument();

         htmlNewDoc.Load("TextWriter.html");

         var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

         Console.WriteLine(node.OuterHtml);

            Console.ReadKey();
        }
    }
}
