using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace jsonNewtonsoft
{
    [JsonObject]
    public class Directory:IEnumerable<string>
    {
        public string Name { get; set; }
        public IList<string> Files { get; set; }

        public Directory()
        {
            Files = new List<string>();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return Files.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
