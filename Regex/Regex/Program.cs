// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration!");
UserRegistration userRegistration = new UserRegistration();
Console.WriteLine("Enter First Name");
string Firstname = Console.ReadLine();
userRegistration.FirstName(Firstname);
