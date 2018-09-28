using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;

namespace NewtonsoftJsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataset = new DataSet("dataset");
            dataset.Namespace = "NetFrameWork";
            DataTable table = new DataTable();
            DataColumn idColumn = new DataColumn("id", typeof(int));
            idColumn.AutoIncrement = true;

            DataColumn itemColumn = new DataColumn("item");
            table.Columns.Add(idColumn);
            table.Columns.Add(itemColumn);
            dataset.Tables.Add(table);

            for(int i=0; i<2; i++)
            {
                DataRow newRow = table.NewRow();
                newRow["item"] = "item" + i;
                table.Rows.Add(newRow);
            }

            dataset.AcceptChanges();

            string json = JsonConvert.SerializeObject(dataset, Formatting.Indented);

            Console.WriteLine(json);

            JavaScriptSettings settings = new JavaScriptSettings()
            {
                OnLoadFunction = new JRaw("OnLoad"),
                OnUnLoadFunction = new JRaw("function(e) { alert(e); }")    
            };

            string json1 = JsonConvert.SerializeObject(settings, Formatting.Indented);

            Console.WriteLine(json1);

            // Serialize conditional property

            Employee joe = new Employee();
            joe.Name = "Joe Employee";
            Employee mike = new Employee();
            mike.Name = "Mike Manager";

            joe.Manager = mike;
            // mike is his own manager 
            // ShouldSerialize will skip this property
            mike.Manager = mike;

            string json2 = JsonConvert.SerializeObject(new[] { joe, mike }, Formatting.Indented);

            Console.WriteLine(json2);

            string json3 = @"{
               'Email':'abhilash456a@gmail.com',
                'Active':true,
'CreatedDate':'2018-01-20T00:00:00Z',
'Roles': [
'User',
'Admin'
]
}";
            Account account = JsonConvert.DeserializeObject<Account>(json3);

            Console.WriteLine(account.Email);

            // Deserialize a Collection

            string json4 = @"['Starcraft','Halo','Legend of Zelda']";
            List<string> videogames = JsonConvert.DeserializeObject<List<string>>(json4);
            Console.WriteLine(String.Join(", ", videogames.ToArray()));

            string json5 = @"{
                'href':'/account/login.aspx',
                'target':'_blank'
                }";

            Dictionary<string, string> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, string>>(json5);

            Console.WriteLine(htmlAttributes["href"]);

            Console.WriteLine(htmlAttributes["target"]);

        }
    }
}
