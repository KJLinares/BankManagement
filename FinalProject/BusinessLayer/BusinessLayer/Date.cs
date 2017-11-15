using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
        [Serializable]
        public class Date
        {
            int month;

            public int Month
            {
                get { return month; }
                set
                {
                    if (value > 0 && value <= 12)
                    {
                        month = value;
                    }
                    else
                        throw new ArgumentOutOfRangeException("Month", value, "Month must be 1-12");
                }
            }
            int year;

            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            int day;

            public int Day
            {
                get { return day; }
                set
                {
                    int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 30, 31, 31, 30, 31, 30, 31 };
                    if (value > 0 && value <= daysPerMonth[Month])
                    {
                        day = value;
                    }
                    else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                    {
                        day = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Day", value, "Day out of range for current month/year");
                    }
                }
            }
            public Date()
            {
                this.month = 00;
                this.year = 0000;
                this.day = 00;
            }
            public Date(int month, int day, int year)
            {
                this.month = month;
                this.day = day;
                this.year = year;
            }
            public override String ToString()
            {
                String state = this.month + "/" + this.day + "/" + this.year;
                return state;
            }
        }
}
