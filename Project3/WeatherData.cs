using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class WeatherData
    {
        DateTime dt;
        double temperature;

        public WeatherData(int m, int d, int y, double temp)
        {
            dt = new DateTime(y, m, d);
            temperature = temp;
        }
        public override string ToString()
        {
            return dt.ToLongDateString() + ": " + temperature + " degrees";
        }

        public int day
        {
            get
            {
                return dt.Day;
            }
        }
        public string dayOfWeek
        {
            get
            {
                return dt.DayOfWeek.ToString();
            }
        }
        public int year
        {
            get
            {
                return dt.Year;
            }
        }
        public int month
        {
            get
            {
                return dt.Month;
            }
        }

    }
}
