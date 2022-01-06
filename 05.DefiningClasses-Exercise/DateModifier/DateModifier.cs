using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    class DateModifier
    {
        public int GetDaysDifference(string startDateString, string endDateString)
        {
            DateTime startDate = DateTime.Parse(startDateString);
            DateTime endDate = DateTime.Parse(endDateString);

            var totalDays = (int)Math.Abs((startDate - endDate).TotalDays);

            return totalDays;
        }
    }
}
