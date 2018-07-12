using System.Text.RegularExpressions;

namespace DotNetCoreExtensions.Strings
{
    /// <summary>
    /// Removes all newline characters from string.
    /// </summary>
    public static partial class StringExtensions 
    {
        public static string RemoveNewLines(this string input)
        {
            return Regex.Replace(input,"\n", "");
        }
    }
}