using System.Text.RegularExpressions;

namespace DotNetCoreExtensions.Strings
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Extension method that converts a string object's value to snake case.
        /// </summary>
        /// <param name="input">String to be converted.</param>
        /// <returns>The converted string.</returns>
        public static string ToKebabCase(this string input)
        {
            var output = Regex.Replace(input, "[a-z0-9][A-Z]", match => match.Value[0] + "-" + match.Value[1]).ToLower();
            return output;
        }
    }
}