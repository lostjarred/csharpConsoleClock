using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClock
{
    public class Clockutils
    {
        DateTime datetimenow;
        public Clockutils()
        {
            updatedatetime();
        }

        //update the variable
        public void updatedatetime()
        {
            datetimenow = System.DateTime.Now;
        }

        //get hour int
        public int getHour()
        {
            return datetimenow.Hour;
        }

        //get minute int
        public int getMinute()
        {
            return datetimenow.Minute;
        }

        //get second int
        public int getSecond()
        {
            return datetimenow.Second;
        }

        //get day int
        public int getDay()
        {
            return datetimenow.Day;
        }

        //get month int
        public int getMonth()
        {
            return datetimenow.Month;
        }

        //get year int
        public int getYear()
        {
            return datetimenow.Year;
        }

        //Decimal
        //convet to string dec so no conversion necessay
        public string Decgethour()
        {
            return Convert.ToString(getHour());
        }

        public string Decgetminute()
        {
            return Convert.ToString(getMinute());
        }

        public string Decgetsecond()
        {
            return Convert.ToString(getSecond());
        }

        public string Decgetday()
        {
            return Convert.ToString(getDay());
        }

        public string Decgetmonth()
        {
            return Convert.ToString(getMonth());
        }

        public string Decgetyear()
        {
            return Convert.ToString(getYear());
        }

        public string Dectime()
        {
            return Decgethour() + ":" + Decgetminute() + ":" + Decgetsecond();
        }

        public string Decdate()
        {
            return Decgetday() + "." + Decgetmonth() + "." + Decgetyear();
        }

        //Bineary
        public string Bingethour()
        {
            return Convert.ToString(getHour(), 2);
        }
        public string Bingetminute()
        {
            return Convert.ToString(getMinute(), 2);
        }
        public string Bingetsecond()
        {
            return Convert.ToString(getSecond(), 2);
        }

        public string Bingetday()
        {
            return Convert.ToString(getDay(), 2);
        }

        public string Bingetmonth()
        {
            return Convert.ToString(getMonth(), 2);
        }

        public string Bingetyear()
        {
            return Convert.ToString(getYear(), 2);
        }
        public string Bintime()
        {
            return Bingethour() + ":" + Bingetminute() + ":" + Bingetsecond();
        }
        public string Bindate()
        {
            return Bingetday() + "." + Bingetmonth() + "." + Bingetyear();
        }

        //octal 
        public string Octgethour()
        {
            return Convert.ToString(getHour(), 8);
        }

        public string Octgetminute()
        {
            return Convert.ToString(getMinute(), 8);
        }
        public string Octgetsecond()
        {
            return Convert.ToString(getSecond(), 8);
        }

        public string Octgetday()
        {
            return Convert.ToString(getDay(), 8);
        }
        public string Octgetmonth()
        {
            return Convert.ToString(getMonth(), 8);
        }
        public string Octgetyear()
        {
            return Convert.ToString(getYear(), 8);
        }

        public string Octtime()
        {
            return Octgethour() + ":" + Octgetminute() + ":" + Octgetsecond();
        }
        public string Octdate()
        {
            return Octgetday() + "." + Octgetmonth() + "." + Octgetyear();
        }

        //hexidecimal
        public string Hexgethour()
        {
            return Convert.ToString(getHour(), 16);
        }
        public string Hexgetminute()
        {
            return Convert.ToString(getMinute(), 16);
        }
        public string Hexgetsecond()
        {
            return Convert.ToString(getSecond(), 16);
        }
        public string Hexgetday()
        {
            return Convert.ToString(getDay(), 16);
        }
        public string Hexgetmonth()
        {
            return Convert.ToString(getMonth(), 16);
        }
        public string Hexgetyear()
        {
            return Convert.ToString(getYear(), 16);
        }
        public string Hextime()
        {
            return Hexgethour() + ":" + Hexgetminute() + ":" + Hexgetsecond();
        }
        public string Hexdate()
        {
            return Hexgetday() + "." + Hexgetmonth() + "." + Hexgetyear();
        }
    }
}
