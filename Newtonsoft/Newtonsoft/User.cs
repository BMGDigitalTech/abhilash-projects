using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Newtonsoft
{
    public enum UserStatus { NotConfirmed, Active, Deleted }

    [JsonConverter(typeof(UserConverter))]
    class User
    {
        public string UserName { get; private set; }
        public bool Enabled { get; private set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public UserStatus Status { get; set; }

        public User()
        {

        }

        [JsonConstructor]
        public User(string userName, bool enabled)
        {
            UserName = userName;
            Enabled = enabled;
        }
    }
}
