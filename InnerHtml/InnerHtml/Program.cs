using HtmlAgilityPack;
using System;

namespace InnerHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            var html =
                 @"<body>
                    <h1>This is <b>bold</b> heading</h1>
                    <p>This is <u>underlined</u> paragraph</p>
			
			        <h1>This is <i>italic</i> heading</h1>
			        <p>This is <u>underlined</u> paragraph</p>
                </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//body/h1");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("InnerHtml");
            foreach(var node in htmlNodes)
            {
                Console.WriteLine(node.InnerHtml);
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("InnerText");
            foreach(var node in htmlNodes)
            {
                Console.WriteLine(node.InnerText);
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("OuterHtml");
            foreach(var node in htmlNodes)
            {
                Console.WriteLine(node.OuterHtml);
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("ParentNode of h1 is :");
            var selectSingleNode = htmlDoc.DocumentNode.SelectSingleNode("//body/h1");

            HtmlNode parentNode = selectSingleNode.ParentNode;

            Console.WriteLine(parentNode.Name);

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Child nodes present initially");
            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");
            DisplayChildNodes(htmlBody);

            HtmlNode h2Node = HtmlNode.CreateNode("<h2> This is h2 heading</h2>");

            htmlBody.AppendChild(h2Node);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("After child node appended");

            DisplayChildNodes(htmlBody);

            HtmlNode h3Node = HtmlNode.CreateNode("<h3> THis is H2 heading</h3>");
            HtmlNode pNode1 = HtmlNode.CreateNode("<p>This is appended paragraph 1</p>");
            HtmlNode pNode2 = HtmlNode.CreateNode("<p>This is appended paragraph 2</p>");

            HtmlNodeCollection children = new HtmlNodeCollection(htmlBody);

            children.Add(h3Node);
            children.Add(pNode1);
            children.Add(pNode2);

            htmlBody.AppendChildren(children);

            Console.WriteLine("\n*********************After children appended**********************");
            DisplayChildNodes(htmlBody);

            HtmlNode newHtmlBody = htmlBody.Clone();

            Console.WriteLine("\n Duplicate Node Name :" + newHtmlBody.Name);

            Console.WriteLine("\n*********************** Display children of the duplicate node **************************\n");

            DisplayChildNodes(newHtmlBody);

            var htmlBodyTwo = htmlBody.CloneNode(false);

            Console.WriteLine("\n Clone Node Name: " + newHtmlBody.Name);

            Console.WriteLine("\n************* Display children of the clone node *******************\n");

            DisplayChildNodes(htmlBodyTwo);

            HtmlNode h1Node = htmlBody.ChildNodes[1];

            DisplayNode(h1Node);

            HtmlNode h4Node = h1Node.CloneNode("h2", true);

            Console.WriteLine("\n************* CLone node *********************\n");

            DisplayNode(h4Node);

            HtmlNode h5Node = htmlBody.ChildNodes[1];

            DisplayNode(h5Node);

            HtmlNode h6Node = h5Node.CloneNode("h6", true);

            Console.WriteLine("\n*************** Clone node ***********************\n");

            DisplayNode(h6Node);

            HtmlNode newBody = HtmlNode.CreateNode("<body></body>");

            newBody.CopyFrom(htmlBody);

            DisplayNode(htmlBody);

            Console.WriteLine("\n****************** Display node **********************\n");

            DisplayNode(newBody);

            HtmlNode newBody2 = HtmlNode.CreateNode("<body></body>");

            newBody2.CopyFrom(htmlBodyTwo, false);

            DisplayNode(htmlBodyTwo);

            Console.WriteLine("\n **************** Duplicate node ********************\n");

            DisplayNode(newBody2);

            HtmlNode newPara = HtmlNode.CreateNode("<p>This is new paragraph</p>");

            htmlBodyTwo.ChildNodes.Add(newPara);

            Console.WriteLine("\n ***************** After adding new child node ************\n");

            DisplayNode(htmlBodyTwo);

           

            Console.ReadKey();
        }

        static void DisplayNode(HtmlNode node)
        {
            Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

            Console.Write("\n" + node.Name + " children: \n");

            DisplayChildNodes(node);
        }

        static void DisplayChildNodes(HtmlNode nodeElement)
        {
            HtmlNodeCollection childNodes = nodeElement.ChildNodes;

            if(childNodes.Count == 0)
            {
                Console.WriteLine(nodeElement.Name + " has no children");
            } else
            {
                foreach (var node in childNodes)
                {
                    if (node.NodeType == HtmlNodeType.Element)
                    {
                        Console.WriteLine(node.Name);
                    }
                }
            }

            
        }
    }
}
