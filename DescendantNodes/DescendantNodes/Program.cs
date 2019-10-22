using System;
using HtmlAgilityPack;

namespace DescendantNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = @"<html><body><h1>THis is h1 heading</h1><p>This is paragraph</p></body></html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach(var nNode in node.DescendantNodes())
            {
                if(nNode.NodeType == HtmlNodeType.Element)
                {
                    Console.WriteLine(nNode.Name);
                }
            }

            Console.WriteLine("************** Descendant nodes and self *************************");

            foreach(var nNode in node.DescendantNodesAndSelf())
            {
                if(nNode.NodeType == HtmlNodeType.Element)
                {
                    Console.WriteLine(nNode.Name);
                }
            }

            Console.ReadLine(); 
        }
    }
}
