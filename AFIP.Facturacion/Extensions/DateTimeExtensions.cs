using System;
using System.Collections.Generic;
using System.Text;

namespace AFIP.Facturacion.Extensions
{
    internal static class DateTimeExtensions
    {
        public static string ToAFIPDateString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyyMMdd");
        }
    }
}
