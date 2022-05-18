// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration!");
UserRegistration First = new UserRegistration();
Console.WriteLine("Enter First Name");
string Firstname = Console.ReadLine();
First.FirstName(Firstname);
