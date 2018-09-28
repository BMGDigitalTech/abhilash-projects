using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Newtonsoft
{
    public class UserConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(User);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string username = (string)reader.Value;
            User user = new User(username, true);
            return user;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            User user = (User)value;
            writer.WriteValue(user.UserName);
            //writer.WriteValue(user.Enabled);
            //writer.WriteValue(user.Status);
        }


    }
}
