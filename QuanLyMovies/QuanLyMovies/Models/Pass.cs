using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuanLyMovies.Models
{
    class Pass : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex(@"^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$ ");
            Match match = regex.Match(value.ToString());
            var kq = new ValidationResult(true, null);
            if (match == null || match == Match.Empty)
            {
                kq = new ValidationResult(false, "Mật khẩu chưa mạnh");
            }
            return kq;
        }
    }
}
