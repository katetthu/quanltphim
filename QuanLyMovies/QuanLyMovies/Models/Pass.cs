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
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            Match match = regex.Match(value.ToString());
            var kq = new ValidationResult(true, null);
            if (match == null || match == Match.Empty)
            {
                kq = new ValidationResult(false, "Password not strong");
            }
            return kq;
        }
    }
}
