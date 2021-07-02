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
    class Card : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double num;
            var kq = new ValidationResult(true, null);
            var phone = value as string;
            if (!double.TryParse(value.ToString(), out num))
            {
                kq = new ValidationResult(false, "Please input card number");
            }
            else if (phone.Length < 9 || phone.Length > 14)
            {
                kq = new ValidationResult(false, "9 ~ 14 numbers");
            }
            return kq;
        }
    }
}
