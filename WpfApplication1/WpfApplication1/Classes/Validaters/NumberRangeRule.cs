using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1.Classes.Validaters
{
    public class NumberRangeRule : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int res = 0;
            if (int.TryParse(value.ToString(), out res))
            {
                if (res < Min || res > Max)
                {
                    return new ValidationResult(false, String.Format("Number must be in range {0} - {1}", Min, Max));
                }
            }
            return ValidationResult.ValidResult;
        }
    }
}
