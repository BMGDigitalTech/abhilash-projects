using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace jsonNewtonsoft
{
    public class Videogame
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
    }


}
