using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MediaMarkup.Core
{
    public class LongDataTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var val = JToken.FromObject(value.ToString());
            val.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.TokenType != JsonToken.String ? 0 : long.Parse(reader.Value.ToString());
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
