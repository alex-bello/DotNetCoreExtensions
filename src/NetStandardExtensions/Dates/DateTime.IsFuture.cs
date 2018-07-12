using System;
using System.Collections.Generic;

namespace NetStandardExtensions.Dates
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// Extension method the indicates whether or not a DateTime object's date value is not in the future.
        /// </summary>
        /// <param name="d">The DateTime object to be evaluated.</param>
        /// <returns>Boolean value indicating whether date is in the future or not.</returns>
        public static bool IsFuture(this DateTime input)
        {
            return input.Date > DateTime.Now.Date ? true : false;
        }
    }
}

