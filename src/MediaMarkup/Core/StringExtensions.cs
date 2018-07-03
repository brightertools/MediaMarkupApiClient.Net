namespace MediaMarkup.Core
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string value)
        {                    
            if(!string.IsNullOrEmpty(value) && value.Length > 1)
            {
                return char.ToLowerInvariant(value[0]) + value.Substring(1);
            }
            return value;
        }
    }
}
