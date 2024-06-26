using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    internal class ColumnData
    {
        internal DateTime StartDate { get; set; }
        internal DateTime EndDate { get; set; }

        internal static List<DataColumn> GenerateColumnData(Account account)
        {
            
            List<DataColumn> columns = new List<DataColumn>();  
            DataColumn dataColumn = new DataColumn();
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

                DateTime StartDate = new DateTime(year, month, 1);
                DateTime EndDate = firstHalfEndDate;
                
                columns.Add(new DataColumn($"{startDate.ToString("MMM")} 1-15\n{startDate.Year}", Type.GetType("System.Decimal")));
                columns.Add(new DataColumn($"{startDate.ToString("MMM")} 16-{secondHalfEndDate.Day}\n{startDate.Year}", Type.GetType("System.Decimal")));
                startDate = startDate.AddMonths(1);
            }
            return columns;
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
