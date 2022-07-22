using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingDayDal
{
    public static class StringMethods
    {
        public static bool IsNumeric(this string text) // Zu erweiternder Typ muss 1. Parameter sein und mit "this" gekennzeichnet sein
        {
            return Double.TryParse(text, out _);
        }
    }
}
