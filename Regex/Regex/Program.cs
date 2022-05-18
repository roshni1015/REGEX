// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1) FirstName Validation\n2) LastName Validation \n3) Email Validation \n4) MobileNumber Validation \n5) Password with 8 Character \n6) Password with at least 1 Upper Case \n7) Password with at least 1 Numeric Case \n8) Password with 1 Special Character");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            UserRegistration First = new UserRegistration();
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            Console.WriteLine();
            First.FirstName(Firstname);
            Console.WriteLine("******************************************************************");
            break;
        case 2:
            UserRegistration Last = new UserRegistration();
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            Console.WriteLine();
            Last.LastName(Lastname);
            Console.WriteLine("******************************************************************");
            break;
        case 3:
            UserRegistration emailID = new UserRegistration();
            Console.WriteLine("Enter EmailId");
            string EmailId = Console.ReadLine();
            Console.WriteLine();
            emailID.Email(EmailId);
            Console.WriteLine("******************************************************************");
            break;
        case 4:
            UserRegistration Mobile = new UserRegistration();
            Console.WriteLine("Enter Mobile Number");
            string Number = Console.ReadLine();
            Console.WriteLine();
            Mobile.MobileNumber(Number);
            Console.WriteLine("******************************************************************");
            break;
        case 5:
            UserRegistration PasswordRule1 = new UserRegistration();
            Console.WriteLine("Enter Password");
            string Passwordrule1 = Console.ReadLine();
            Console.WriteLine();
            PasswordRule1.Rule1(Passwordrule1);
            Console.WriteLine("******************************************************************");
            break;
        case 6:
            UserRegistration PasswordRule2 = new UserRegistration();
            Console.WriteLine("Enter Password");
            string Passwordrule2 = Console.ReadLine();
            Console.WriteLine();
            PasswordRule2.Rule2(Passwordrule2);
            Console.WriteLine("******************************************************************");
            break;
        case 7:
            UserRegistration PasswordRule3 = new UserRegistration();
            Console.WriteLine("Enter Password");
            string Passwordrule3 = Console.ReadLine();
            Console.WriteLine();
            PasswordRule3.Rule3(Passwordrule3);
            Console.WriteLine("******************************************************************");
            break;
        case 8:
            UserRegistration PasswordRule4 = new UserRegistration();
            Console.WriteLine("Enter Password");
            string Passwordrule4 = Console.ReadLine();
            Console.WriteLine();
            PasswordRule4.Rule4(Passwordrule4);
            Console.WriteLine("******************************************************************");
            break;
        default:
            Console.WriteLine("Worng Input.");
            break;
    }
}