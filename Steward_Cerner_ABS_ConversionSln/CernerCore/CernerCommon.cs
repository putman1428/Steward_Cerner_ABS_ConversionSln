using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestBARConversion.CernerCore
{
    public class CernerCommon
    {
        public static string GetHCISTimeZone(string hcis)
        {
            string result = string.Empty;
            if (hcis == "SHAZ" || hcis == "SHUT")
                result = "US Mountain Standard Time";
            else
                result = "Central Standard Time";

            return result;
        }
        public static DateTime? GetCernerDate(string dateValue)
        {
            DateTime? result = null;
            if (dateValue.Trim().Length > 0 && dateValue != "null")
                result = DateTime.ParseExact(dateValue, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture);
            return result;
        }
        public static DateTime? GetCernerDate(string dateValue, string hcis)
        {
            string timeZone = GetHCISTimeZone(hcis);
            DateTime? dt2 = null;

            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTime? dt = CernerCommon.GetCernerDate(dateValue);
            if (dt.HasValue)
                dt2 = TimeZoneInfo.ConvertTimeFromUtc(dt.Value, tzi);
            return dt2;
        }

        internal static string StripDecimalsForMap(string cd)
        {
            string result = cd;
            if (cd == ".0000")
                result = string.Empty;
            else
                if (cd.Length > 5)
                    result = cd.Substring(0, cd.Length - 5);
            
            return result;
        }

        public static string GetMeditechVisitPrefix(string visitnbr)
        {
            string result = string.Empty;
            string prefix = visitnbr.Substring(0, 2);
            if (prefix == "14")
                result = "ZQ";
            if (prefix == "15")
                result = "ZV";
            if (prefix == "16")
                result = "ZU";
            if (prefix == "17")
                result = "YK";
            return result;
        }

        public static bool IsNumeric(string data)
        {
            long n;
            bool isNumeric = long.TryParse(data, out n);
            return isNumeric;
        }

        internal static DateTime? ConvertDateString(string dt)
        {
            DateTime? result = null;
            if (dt.Trim().Length > 0 && dt != "null")
                result = Convert.ToDateTime(dt);
            return result;
        }
        public static decimal? ConvertDecimalString(string amount)
        {
            decimal? result = null;
            if (amount.Trim().Length > 0)
                result = Convert.ToDecimal(amount);
            return result;
        }
        internal static string GetPhysiicanType(string physType)
        {
            string result = string.Empty;
            if (physType == "1116.0000")
                result = "ADMIT";
            if (physType == "1119.0000")
                result = "ATTEND";
            if (physType == "1121.0000")
                result = "CONSULT";
            if (physType == "1126.0000")
                result = "REFER";
            return result;
        }
        public static string GetSSN(string num)
        {
            num = num.Trim();
            if (num == "") 
                return "";
            if(num.Length == 9)
                num = num.Substring(0, 3) + "-" + num.Substring(3, 2) + "-" + num.Substring(5);
            if (num.Trim() == "000-00-0000" || num.Trim() == "999-99-9999")
                return "";
            else
                return num;
        }
    }
}
