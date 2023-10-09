using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralOperationalLibrary
{
    public static class ObjectToText
    {
        public static string NumberWithCommas(decimal value, int Digits)
        {
            string formatString = "N" + Digits.ToString();
            return value.ToString(formatString);
        }

        public static string Percent(decimal value, int Digits)
        {
            string formatString = "P" + Digits.ToString();
            return value.ToString(formatString);
        }
    }
}
