﻿//using System; Reutiliza o namespace
using System.Collections.Generic;
using System.Text;

namespace System
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1") + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1") + " days";
            }
        }
    }
}
