using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal class MonthHeader
    {
        internal string HeaderText { get; set; }
        internal DateTime StartDate { get; set; }
        internal DateTime EndDate { get; set; }



        internal static Queue<MonthHeader> GenerateMonthHeaders(Account account)
        {
            var monthHeaders = new Queue<MonthHeader>();
            DateTime startDate = account.StartDate;
            int numMonths = GetMonthsBetween(startDate, DateTime.Today) + 6;
            for (int i = 0; i < numMonths; i++)
            {
                int year = startDate.Year;
                int month = startDate.Month;

                // Calculate the end of the first half of the month
                int firstHalfEndDay = 15;
                DateTime firstHalfEndDate = new DateTime(year, month, firstHalfEndDay);

                // Calculate the end of the month
                DateTime secondHalfEndDate = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);

                monthHeaders.Enqueue(new MonthHeader
                {
                    StartDate = new DateTime(year, month, 1),
                    EndDate = firstHalfEndDate,
                    HeaderText = $"{startDate.ToString("MMM")} 1-15\n{startDate.Year}"
                });

                monthHeaders.Enqueue(new MonthHeader
                {
                    StartDate = firstHalfEndDate.AddDays(1),
                    EndDate = secondHalfEndDate,
                    HeaderText = $"{startDate.ToString("MMM")} 16-{secondHalfEndDate.Day}\n{startDate.Year}"
                });
                startDate = startDate.AddMonths(1);
            }
            return monthHeaders;
        }
        public static int GetMonthsBetween(DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart);
        }

        public bool inBetweenDates(DateTime dateTime)
        {
           return dateTime >= this.StartDate && dateTime <= this.EndDate;
        }

    }
}
