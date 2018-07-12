using System.Text;

namespace DotNetCoreExtensions.Strings
{
    public static partial class StringExtensions 
    {
        public static string Repeat(this string s, int n)
        {
            return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        }
    }
}