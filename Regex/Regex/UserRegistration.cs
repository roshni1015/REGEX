using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    public class UserRegistration
    {
        public bool FirstName(string Firstname)
        {
            bool status;
            string firstname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(Firstname))
            {
                status = true;
                Console.WriteLine("First Name is Valid ");
                Console.WriteLine();

            }
            else
            {
                status = false;
                Console.WriteLine("Please Enter First Letter Capital");
                Console.WriteLine();

            }
            return status;

        }
        public bool LastName(string Lastname)
        {
            bool status;
            string lastname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(Lastname))
            {
                status = true;
                Console.WriteLine("Last Name is Valid ");
                Console.WriteLine();

            }
            else
            {
                status = false;
                Console.WriteLine("Please Enter First Letter Capital");
                Console.WriteLine();
 
            }
            return status;

        }


    }
}
