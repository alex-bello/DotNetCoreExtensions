namespace NetStandardExtensions.Strings
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Extension method that replaces the last occurence of a search string with the replace value.
        /// </summary>
        /// <param name="searchString">The string to be replaced.</param>
        /// <param name="replaceString">The string to replace searchString with. If null, removes searchString.</param>
        /// <returns>The updated string.</returns>
        public static string ReplaceLast(this string input, string searchString, string replaceString = "")
        {
            int index = input.LastIndexOf(searchString);
            return input.Remove(index, searchString.Length).Insert(index, replaceString);
        }
        
    }
}