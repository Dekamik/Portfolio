using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Common.Helpers
{
    public static class DateHelper
    {
        public static int GetYearsBetween(DateTime from, DateTime to)
        {
            if (from > to)
            {
                throw new ArgumentOutOfRangeException("To must be a date after from");
            }
            return (int)Math.Floor((to - from).TotalDays / 365.25D);
        }
    }
}
