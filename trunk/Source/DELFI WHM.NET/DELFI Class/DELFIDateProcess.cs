using System;
using System.Collections.Generic;
using System.Text;

namespace DELFI_WHM.NET.DELFI_Class
{
    public class DELFIDateProcess
    {
        public static String Format(string sFormat, DateTime dObj)
        {
            return string.Format(sFormat, dObj);
        }
        public static String ToStandartFormat(DateTime dDate)
        {
            return string.Format("{0:dd/MM/yyyy}", dDate);
        }
        public static String ToStandartFormat(string sDDate)
        {
            DateTime D;
            if (DateTime.TryParse(sDDate, out D))
                return string.Format("{0:dd/MM/yyyy}", D);
            else
                return "";
        }
        public static String DatetoString(DateTime dDate)
        {
            return (dDate.Day.ToString().Length < 2 ? "0" + dDate.Day.ToString() : dDate.Day.ToString()) + "/" + (dDate.Month.ToString().Length < 2 ? "0" + dDate.Month.ToString() : dDate.Month.ToString()) + "/" + dDate.Year.ToString();
        }
        public static bool GetVDate(string VDateString, out DateTime dDate)
        {
            return DateTime.TryParse(WDate(VDateString), out dDate);
        }
        public static bool GetDate(string DateString, out DateTime dDate)
        {
            return DateTime.TryParse(DateString, out dDate);
        }
        public static String VDate(String sDate)
        {
            DateTime d;
            if (!DateTime.TryParse(sDate, out d)) return "";
            return (d.Day.ToString().Length < 2 ? "0" + d.Day.ToString() : d.Day.ToString()) + "/" + (d.Month.ToString().Length < 2 ? "0" + d.Month.ToString() : d.Month.ToString()) + "/" + d.Year.ToString();
        }
        public static String WDate(String sDate)
        {
            String[] tmp = sDate.Split("/-".ToCharArray());
            if (tmp.Length != 3)
                return "";
            DateTime d;
            if (!DateTime.TryParse(tmp[1] + "/" + tmp[0] + "/" + tmp[2], out d)) return "";
            return (d.Month.ToString().Length < 2 ? "0" + d.Month.ToString() : d.Month.ToString()) + "/" + (d.Day.ToString().Length < 2 ? "0" + d.Day.ToString() : d.Day.ToString()) + "/" + d.Year.ToString();
        }
        public static int VDateSubtrack(String sDate1, String sDate2)
        {
            DateTime D1 = DateTime.Parse(WDate(sDate1)), D2 = DateTime.Parse(WDate(sDate2));
            double kq = D1.ToOADate() - D2.ToOADate();
            return (int)kq;
        }
        public static int WDateSubtrack(String sDate1, String sDate2)
        {
            DateTime D1 = DateTime.Parse(sDate1), D2 = DateTime.Parse(sDate2);
            return (int)(D1.ToOADate() - D2.ToOADate());
        }
    }
}
