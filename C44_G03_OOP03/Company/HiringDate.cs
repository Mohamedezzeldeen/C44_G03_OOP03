using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03.Company
{
    public class HiringDate
    {
        private int Day;
        private int Month;
        private int Year;


        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int year
        {
            get { return Year; }
            set { Year = value >= 1900 && value <= 2025 ? value : 0; }
        }

        public int month
        {
            get { return Month; }
            set { Month = value >= 1 && value <= 12 ? value : 0; }
        }
        public int day
        {
            get { return Day; }
            set { Day = value >= 1 && value <= 31 ? value : 0; }
        }

        public override string ToString()
        {
            return $"Year = {Year} / Month = {Month} / Day = {Day}";
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
    }
}
