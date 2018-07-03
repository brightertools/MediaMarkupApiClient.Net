using System.Net;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace MediaMarkup.Core
{
    public static class ObjectExtensions
    {
        public static string ToQueryStringValues(this object model)
        {
            var urlBuilder = new StringBuilder();
            var properties = model.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var property in properties)
            {
                urlBuilder.Append($"{property.Name.ToCamelCase()}={WebUtility.UrlEncode(property.GetValue(model, null).ToString())}&");
            }
            if (urlBuilder.Length > 1)
            {
                urlBuilder.Remove(urlBuilder.Length - 1, 1);
            }
            return urlBuilder.ToString();
        }

        public static string ToJson(this object value, Formatting formatting = Formatting.None)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            return JsonConvert.SerializeObject(value, formatting, settings);
        }
    }
}