namespace DotNetCoreExtensions.Strings
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Extension method that converts a string object's last word to the singlular form.
        /// </summary>
        /// <param name="input">String to be converted.</param>
        /// <returns>string with the singular form of the word(s) passed to the method.</returns>
        public static string ToSingular(this string input)
        {
            switch (input)
            {
                case "species":
                    return input;
            }
                
            if (input.EndsWith("ies")) return input.ReplaceLast("ies", "y");
            if (input.EndsWith("s")) return input.ReplaceLast("s");
            
            return input;
        }
    }
}