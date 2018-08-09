using System.Collections.Generic;

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
            // Check for exception words first
            switch (input)
            {
                case "species":
                    return input;
                case "calories":
                case "movies":
                    return input.ReplaceLast("s");
            }

            var iesExceptions = new HashSet<string> { "d", "l", "p", "t" };
                
            if (input.EndsWith("ies") && !iesExceptions.Contains(input.Substring(input.Length - 4, 1))) return input.ReplaceLast("ies", "y");
            if (input.EndsWith("s") && !input.EndsWith("ss")) return input.ReplaceLast("s");
            
            return input;
        }
    }
}