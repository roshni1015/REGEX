// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1) FirstName Validation\n2) LastName Validation \n3) Email Validation \n4) MobileNumber Validation \n5) Password with 8 Character \n6) Password with at least 1 Upper Case \n7) Password with at least 1 Numeric Case \n8) Password with 1 Special Character \n9) Email Sample Validation \n10) Custom Exception for FirstName \n11) Custom Exception LastName \n12) customException EmailID \n13) Custom Exception Mobile Number \n14) Custom Exception Password \n15) Lambda Expressions");
    int option = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("------------------------------------");
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
        case 9:
            EmailValidation emailIDvalidation = new EmailValidation();
            Console.WriteLine("Enter EmailId");
            string email = Console.ReadLine();
            Console.WriteLine();
            emailIDvalidation.Email(email);
            Console.WriteLine("******************************************************************");
            break;
        case 10:
            CustomUserregistration Custom1 = new CustomUserregistration();
            string FirstName = Custom1.CustomException_FirstName("Roshni");
            Console.WriteLine(FirstName);
            Console.WriteLine("******************************************************************");
            break;
        case 11:
            CustomUserregistration Custom2 = new CustomUserregistration();
            string LastName = Custom2.CustomException_LastName("Adatrao");
            Console.WriteLine(LastName);
            Console.WriteLine("******************************************************************");
            break;
        case 12:
            CustomUserregistration Custom3 = new CustomUserregistration();
            string Email = Custom3.CustomException_EmailID("abc.def@gl.co.in");
            Console.WriteLine(Email);
            Console.WriteLine("******************************************************************");
            break;
        case 13:
            CustomUserregistration Custom4 = new CustomUserregistration();
            string Mobilenumber = Custom4.CustomException_MobileNumber("+91 1122334455");
            Console.WriteLine(Mobilenumber);
            Console.WriteLine("******************************************************************");
            break;
        case 14:
            CustomUserregistration Custom5 = new CustomUserregistration();
            string PasswordRule = Custom5.CustomException_InvalidPasswordRule("Abc#239");
            Console.WriteLine(PasswordRule);
            Console.WriteLine("******************************************************************");
            break;
        case 15:
            UserRegistration User1 = new();
            Console.WriteLine("Enter Firstname");
            string firstName = Console.ReadLine();
            string output1 = User1.LambdaExpressionFirstname(firstName);
            Console.WriteLine(output1);

            UserRegistration User2 = new();
            Console.WriteLine("Enter Lastname");
            string lasstName = Console.ReadLine();
            string output2 = User2.LambdaExpressionLastname(lasstName);
            Console.WriteLine(output2);

            UserRegistration User3 = new();
            Console.WriteLine("Enter Email");
            string emailId = Console.ReadLine();
            string output3 = User3.LambdaExpressionEmail(emailId);
            Console.WriteLine(output3);

            UserRegistration User4 = new();
            Console.WriteLine("Enter Mobilenumber");
            string mobilenumber = Console.ReadLine();
            string output4 = User4.LambdaExpressionPhoneNumber(mobilenumber);
            Console.WriteLine(output4);

            UserRegistration User5 = new();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            string output5 = User5.LambdaExpressionpassword(password);
            Console.WriteLine(output5);
            break;

        default:
            Console.WriteLine("Wrong Input.");
            break;
    }
}