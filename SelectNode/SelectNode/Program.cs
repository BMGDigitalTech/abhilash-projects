using HtmlAgilityPack;
using System;
using System.Linq;

namespace SelectNode
{
    class Program
    {
        static void Main(string[] args)
        {
            var html =
                @"<TD class=""texte"" width=""50%"">
			        <DIV align=right>Name :<B> </B></DIV>
		        </TD>
		        <TD width=""50%"">
    		        <INPUT class=""box"" value=""John"" maxLength=""1"" size=""16"" name=""user_name"">
    		        <INPUT class=""box"" value=""Tony"" maxLength=""16"" size=""16"" name=""user_name"">
    		        <INPUT class=""box"" value=""Jams"" maxLength=""16"" size=""16"" name=""user_name"">
		        </TD>
		        <TR vAlign=""center"">";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            string name = htmlDoc.DocumentNode
                            .SelectNodes("//td/input")
                            .First()
                            .Attributes["value"].Value;

            Console.WriteLine(name);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//td/input");

            var singlenode = htmlDoc.DocumentNode
                .SelectSingleNode("//td/input")
                .Attributes["value"].Value;

            Console.WriteLine

            foreach(var node in htmlNodes)
            {
                Console.WriteLine(node.Attributes["value"].Value);
            }

            Console.ReadKey();

        }
    }
}
