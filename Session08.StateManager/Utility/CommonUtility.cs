using System;
using System.Collections.Generic;
using System.Text;

namespace Session08.StateManager.Entities.Utility
{
    /// <summary>
    /// متدی برای اصلاح تایپ های از نوع string
    /// </summary>
   public static class CommonUtilityExtention
    {
        public const char ArabicYeChar = (char)1610;
        public const char PersianYeChar = (char)1740;

        public const char ArabicKeChar = (char)1603;
        public const char PersianKeChar = (char)1705;

        public static string ApplyCorrectYeKe(this object data)
        {
            return data == null ? null : ApplyCorrectYeKe(data.ToString());
        }

        public static string ApplyCorrectYeKe(this string data)
        {
            return string.IsNullOrWhiteSpace(data) ?
                        string.Empty :
                        data.Replace(ArabicYeChar, PersianYeChar).Replace(ArabicKeChar, PersianKeChar).Trim();
        }
    }
}
