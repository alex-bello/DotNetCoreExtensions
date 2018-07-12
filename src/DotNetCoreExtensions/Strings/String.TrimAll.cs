using System.Text.RegularExpressions;

namespace DotNetCoreExtensions.Strings
{
    /// <summary>
    /// Removes all excess whitespace characters from string. This includes multiple spaces, tabs, and line breaks.
    /// </summary>
    public static partial class StringExtensions 
    {
        public static string TrimAll(this string s)
        {
            return Regex.Replace(s, @"\s+", " ").Trim();
        }
    }
}