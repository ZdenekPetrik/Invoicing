using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Modul
{
  static class Helper
  {
    public static string DateToMonthYear(DateTime D)
    {
      return D.ToString("yyyy/MM");
    }
    public static string DateToMonthYear(DateTime? D)
    {
      return DateToMonthYear(D ?? DateTime.Now);
    }

    public static string DoubleToMoney(double F)
    {
      return F.ToString("C2");
    }
    public static string DoubleToMoney(double? F)
    {
      return DoubleToMoney(F ?? 0);
    }
    public static string DoubleToMoneyExt(double? F)
    {
      if (F == null)
        return "---Kč";
      else
      return DoubleToMoney(F ?? 0);
    }
    public static string DoubleToMoney00(double F)
    {
      return F.ToString("C0");
    }
    public static string DoubleToMoney00(double? F)
    {
      return DoubleToMoney00(F ?? 0);
    }

    public static string OdApostrofuj(string S)
    {
      return S.Replace("'","").Replace("\"","");
    }

    /// <summary>
    /// Converts a week number to a date.
    /// Note: Week 1 of a year may start in the previous year.
    /// ISO 8601 week 1 is the week that contains the first Thursday that year, so
    /// if December 28 is a Monday, December 31 is a Thursday,
    /// and week 1 starts January 4.
    /// If December 28 is a later day in the week, week 1 starts earlier.
    /// If December 28 is a Sunday, it is in the same week as Thursday January 1.
    /// </summary>
    public static DateTime FromIso8601Weeknumber(int weekNumber, int? year = null, DayOfWeek day = DayOfWeek.Monday)
    {
      var dec28 = new DateTime((year ?? DateTime.Today.Year) - 1, 12, 28);
      var monday = dec28.AddDays(7 * weekNumber - dec28.DayOfWeek.DayOffset());
      return monday.AddDays(day.DayOffset());
    }

    /// <summary>
    /// Iso8601 weeks start on Monday. This returns 0 for Monday.
    /// </summary>
    private static int DayOffset(this DayOfWeek weekDay)
    {
      return ((int)weekDay + 6) % 7;
    }


    public static string DoubleTo00(double? F)
    {
      return DoubleTo00(F ?? 0);
    }
    public static string DoubleTo00(double F)
    {
      return F.ToString("F0");
    }

    public static string DoubleToString(double? F)
    {
      return DoubleToString(F ?? 0);
    }
    public static string DoubleToString(double F)
    {
      return F.ToString("F2");
    }
  }
}
