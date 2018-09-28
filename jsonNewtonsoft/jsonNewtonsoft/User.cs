using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace jsonNewtonsoft
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public int SnakeRating { get; set; }
    }

   
}
