using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace String.StringExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isMailAddress(this string value)
        {
            try
            {
                var mailaddress = new MailAddress(value);
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool containsNarrowString(this string value)
        {
            if (value == null)
            {
                throw new ArgumentException();
            }

            Encoding enc = Encoding.GetEncoding("Shift_JIS");

            int stringBytes = enc.GetByteCount(value);

            return stringBytes != value.Length * 2;

        }

        public static bool containsWideString(this string value)
        {
            if (value == null)
            {
                throw new ArgumentException();
            }

            if (value.isNullOrEmpty())
            {
                return false;
            }

            Encoding enc = Encoding.GetEncoding("Shift_JIS");

            int stringBytes = enc.GetByteCount(value);

            return stringBytes != value.Length;
        }

    }
}
