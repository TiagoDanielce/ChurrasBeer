using System;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.DateTimes
{
    public static class DateTimeExtension
    {
        public static bool IsNotDefault(this DateTime date)
        {
            return !date.Equals(default(DateTime));
        }

        public static DateTime FirstDayOfWeek(this DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-diff).Date;
        }

        public static DateTime LastDayOfWeek(this DateTime dt)
        {
            return dt.FirstDayOfWeek().AddDays(6);
        }

        public static DateTime FirstDayOfMonth(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }

        public static DateTime LastDayOfMonth(this DateTime dt)
        {
            return dt.FirstDayOfMonth().AddMonths(1).AddDays(-1);
        }

        public static DateTime FirstDayOfNextMonth(this DateTime dt)
        {
            return dt.FirstDayOfMonth().AddMonths(1);
        }

        public static DateTime MaxTime(this DateTime dt)
        {
            return dt.AddDays(1).Date.AddSeconds(-1);
        }

        public static double ToTimeStamp(this DateTime dateTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            return (dateTime.ToUniversalTime() - epoch).TotalSeconds;
        }
    }
}
