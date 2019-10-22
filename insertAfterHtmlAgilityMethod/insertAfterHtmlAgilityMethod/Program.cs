using System;
using HtmlAgilityPack;

namespace insertAfterHtmlAgilityMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var html =
                @"<body>
                        <h1>This is <b>bold</b> heading</h1>
                        <p>This is <u>underlined</u> paragraph</p>
                    </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode refChild = htmlBody.ChildNodes[1];

            HtmlNode newChild = HtmlNode.CreateNode("<p> This is inserted after node paragraph");

            DisplayNode(htmlBody);

            htmlBody.InsertAfter(newChild, refChild);

            Console.WriteLine("\n ******** Node inserted after first child ***************\n");

            DisplayNode(htmlBody);

            HtmlNode newChild2 = HtmlNode.CreateNode("<h1> This is inserted before node heading</h1>");

            htmlBody.InsertBefore(newChild2, refChild);

            Console.WriteLine("\n ************ Node inserted after second child ********************\n");

            DisplayNode(htmlBody);

            Console.WriteLine("\n *************** Node inserted in the beginning ******************\n");

            HtmlNode newChild3 = HtmlNode.CreateNode("<h1> This is added at the beginning</h1>");

            htmlBody.PrependChild(newChild3);

            DisplayNode(htmlBody);

            Console.WriteLine("\n ****************** Prepend Children method ********************\n");

            HtmlNode H1Node = HtmlNode.CreateNode("<h1>This is new heading</h1>");

            HtmlNode pNode = HtmlNode.CreateNode("<p>This is new paragraph 1</p>");

            HtmlNodeCollection newChildren = new HtmlNodeCollection(htmlBody);

            newChildren.Add(H1Node);
            newChildren.Add(pNode);

            htmlBody.PrependChildren(newChildren);

            DisplayNode(htmlBody);

            Console.ReadLine();

        }

        static void DisplayNode(HtmlNode node)
        {
            Console.WriteLine("Node Name: " + node.Name);

            Console.Write("\n" + node.Name + " children: \n");

            DisplayChildNodes(node);
        }

        static void DisplayChildNodes(HtmlNode nodeElement)
        {
            HtmlNodeCollection childNodes = nodeElement.ChildNodes;

            if(childNodes.Count == 0)
            {
                Console.WriteLine(nodeElement.Name + " has no children");
            }
            else
            {
                foreach(var node in childNodes)
                {
                    if(node.NodeType == HtmlNodeType.Element)
                    {
                        Console.WriteLine(node.OuterHtml);
                    }
                }
            }
        }
    }
}
