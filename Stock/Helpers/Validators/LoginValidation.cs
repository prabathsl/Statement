using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Stock.Helpers.Validators
{
    public class UserNameValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string property = "User Name";
            try
            {
                string userName = value as string;
                if (string.IsNullOrEmpty(userName))
                {
                    return new ValidationResult(false, string.Format(Resource.Property_Not_Valied, property));
                }
                if (userName.Length<=3)
                {
                    return new ValidationResult(false, string.Format(Resource.Property_Too_Short, property,3));
                }
                return new ValidationResult(true, null);
            }
            catch (Exception)
            {
                return new ValidationResult(false, string.Format(Resource.Property_Not_Valied,property));
            }
        }
    }
    
}
