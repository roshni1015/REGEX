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
        public bool Email(string email)
        {
            bool status;
            string EmailId = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex = new Regex(EmailId);
        
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
        public bool MobileNumber(string Mobilenumber)
        {
            bool status;
            var Number = "^[+0-9]{2}\\s[0-9]{10}$";
            Regex regex = new Regex(Number);

            if (regex.IsMatch(Mobilenumber))
            {
                status = true;
                Console.WriteLine("Given Mobile Number is Valid");
                Console.WriteLine();

            }
            else
            {
                status = false;
                Console.WriteLine("Please Enter Mobile Number in Correct Way");
                Console.WriteLine();

            }
            return status;
        }


    }
}
