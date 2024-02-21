using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyStoreWinApp
{
    internal class Validation
    {
        public static void ValidateString(string s)
        {
            if (s == null || s.Trim().Length == 0) throw new Exception("Empty String");
        }

        public static void ValidateEmail(string email)
        {
            bool isValid = ValidEmailRegex().IsMatch(email);

            if (!isValid) throw new Exception("INVALID EMAIL");
        }

        private static Regex ValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }
    }
}
