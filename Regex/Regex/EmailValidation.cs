using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    public class EmailValidation
    {
        public bool Email(string email)
        {
            bool status;
            string emailFormat = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex = new Regex(emailFormat);

            if (regex.IsMatch(email))
            {
                status = true;
                Console.WriteLine("Given EmailId is Valid");
                Console.WriteLine();

            }
            else
            {
                status = false;
                Console.WriteLine("Please Enter EmailId in Correct Way");
                Console.WriteLine();

            }
            return status;
        }
    }
}
