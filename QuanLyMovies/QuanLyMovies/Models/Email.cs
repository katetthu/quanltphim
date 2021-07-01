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
    class Email : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Match match = regex.Match(value.ToString());
            var kq = new ValidationResult(true, null);
            if (match == null || match == Match.Empty)
            {
                kq = new ValidationResult(false, "Email invalid !");
            }
            return kq;
        }
    }
}
