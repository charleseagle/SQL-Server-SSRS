using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DateFunctions
    {
        public static string LongDateFormat(DateTime AnyDate)
        {
            string suffix;

            switch (AnyDate.Day)
            {
                case 1:
                case 21:
                case 31:
                    suffix = "st";
                    break;
                case 2:
                case 22:
                    suffix = "nd";
                    break;
                case 3:
                case 23:
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }
            return AnyDate.ToString("dddd d") + suffix +
                AnyDate.ToString(" MMMM yyyy");
        }
    }
}
