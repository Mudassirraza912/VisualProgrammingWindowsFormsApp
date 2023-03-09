using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Services
    {
        public static string Guid()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hours = DateTime.Now.Hour;
            int mins = DateTime.Now.Minute;
            int secs = DateTime.Now.Second;

            return year.ToString() + month.ToString() + day.ToString() + hours.ToString() + mins.ToString() + secs.ToString();

        }
    }
}
