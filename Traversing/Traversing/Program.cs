using System;
using HtmlAgilityPack;

namespace Traversing
{
    class Program
    {
        static void Main(string[] args)
        {
            var html =
                @"<html><body><h1>This is <b>bold</b> heading</h1><p>This is <u>underlined</u> paragraph</p></body></html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNodeCollection childNodes = htmlBody.ChildNodes;

            foreach(var n in childNodes)
            {
                if(n.NodeType == HtmlNodeType.Element)
                {
                    Console.WriteLine(n.OuterHtml);
                }
            } 

            Console.WriteLine("************* FirstChild Property **********************");


            HtmlNode firstChild = htmlBody.FirstChild;

            Console.WriteLine(firstChild.OuterHtml);

            Console.WriteLine("******************* LastChild Property **********************");

            HtmlNode lastChild = htmlBody.LastChild;

            Console.WriteLine(lastChild.OuterHtml);

            Console.WriteLine("********************** NextSibling Property ***********************");

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body/h1");

            HtmlNode sibling = node.NextSibling;

            while(sibling != null)
            {
                if(sibling.NodeType == HtmlNodeType.Element)
                {
                    Console.WriteLine(sibling.OuterHtml);
                }

                sibling = sibling.NextSibling;
            }

            Console.WriteLine("***************************** Parent Node *******************************");

            var bh1Node = htmlDoc.DocumentNode.SelectSingleNode("//body/h1");

            HtmlNode parentNode = bh1Node.ParentNode;

            Console.WriteLine(parentNode.Name);

            Console.WriteLine("******************* Get Ancestors of a node ******************");

            var bnode = htmlDoc.DocumentNode.SelectSingleNode("//b");

            foreach(var nNode in bnode.Ancestors())
            {
                if(nNode.NodeType == HtmlNodeType.Element)
                {
                    Console.WriteLine(nNode.Name);
                }
            }

            Console.WriteLine("*********************** Name of ancestors with matching name **********************");

            foreach(var nNode in bnode.Ancestors("body"))
            {
                if(nNode.NodeType == HtmlNodeType.Element)
                {
                    Console.WriteLine("Node name: " + nNode.Name);
                    Console.WriteLine(nNode.InnerText);
                }
            }
            Console.ReadKey();
        }
    }
}
