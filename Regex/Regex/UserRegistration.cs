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
            var Number = "^[+0-9]{3}\\s[0-9]{10}$";
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
        public bool Rule1(string Password)
        {
            bool status;
            var Passwordrule1 = "^[0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(Passwordrule1);

            if (regex.IsMatch(Password))
            {
                status = true;
                Console.WriteLine("Password is Valid");
                Console.WriteLine();

            }
            else
            {
                status = false;
                Console.WriteLine("Incorrect Password");
                Console.WriteLine();

            }
            return status;
        }
        public bool Rule2(string Password)
        {
            bool status;
            var Passwordrule2 = "^(?=.*[A-Z])[0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(Passwordrule2);

            if (regex.IsMatch(Password))
            {
                status = true;
                Console.WriteLine("Password is Valid");
                Console.WriteLine();

            }
            else
            {
                status = false;
                Console.WriteLine("Incorrect Password");
                Console.WriteLine();

            }
            return status;
        }
        public bool Rule3(string Password)
        {
            bool status;
            var Passwordrule3 = "^(?=.*[0-9A-Z])[0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(Passwordrule3);

            if (regex.IsMatch(Password))
            {
                status = true;
                Console.WriteLine("Password is Valid");
                Console.WriteLine();

            }
            else
            {
                status = false;
                Console.WriteLine("Incorrect Password");
                Console.WriteLine();

            }
            return status;
        }
        public bool Rule4(string Password)
        {
            bool status;
            var Passwordrule4 = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(Passwordrule4);

            if (regex.IsMatch(Password))
            {
                status = true;
                Console.WriteLine("Password is Valid");
                Console.WriteLine();

            }
            else
            {
                status = false;
                Console.WriteLine("Incorrect Password");
                Console.WriteLine();

            }
            return status;
        }

        public string FirstName_Format = "^[A-Z]{1}[a-z]{2,}$";
        public string LastName_Format = "^[A-Z]{1}[a-z]{2,}$";
        public string MobileNumber_Format = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public string EmailId_Format = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})$";
        public string Password_Format = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";


        public string LambdaExpressionFirstname(string firstName) => Regex.IsMatch(firstName, FirstName_Format) ? "First Name is Valid!" : "First Name is not Valid!";
        public string LambdaExpressionLastname(string lastName) => Regex.IsMatch(lastName, LastName_Format) ? "Last Name is Valid!" : "Last Name is not Valid!";
        public string LambdaExpressionEmail(string email) => Regex.IsMatch(email, EmailId_Format) ? "Email is Valid!" : "Email is not Valid!";
        public string LambdaExpressionPhoneNumber(string MobileNumber) => Regex.IsMatch(MobileNumber, MobileNumber_Format) ? "Phone Number is Valid!" : "Phone Number is not Valid!";
        public string LambdaExpressionpassword(string password) => Regex.IsMatch(password, Password_Format) ? "Password is Valid!" : "Password is not Valid!";






    }
}
