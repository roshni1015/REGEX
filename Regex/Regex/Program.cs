﻿// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1) FirstName Validation\n2) LastName Validation \n3) Email Validation");
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
        default:
            Console.WriteLine("Wrong Input.");
            break;
    }
}
