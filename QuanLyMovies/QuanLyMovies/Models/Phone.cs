using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuanLyMovies.Models
{
    class Phone : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int num;
            var kq = new ValidationResult(true, null);
            var phone = value as string;
            if (!int.TryParse(value.ToString(), out num))
            {
                kq = new ValidationResult(false, "Please input phone numbers");
            }
            else if (phone.Length != 10 && phone.Length != 11)
            {
                kq = new ValidationResult(false, "10 ~ 11 numbers");
            }
            return kq;
        }
    }
}
